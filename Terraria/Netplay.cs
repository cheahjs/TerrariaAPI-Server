using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Hooks;

namespace Terraria
{
    public class Netplay
    {
        public const int bufferSize = 1024;
        public const int maxConnections = 256;
        public static bool stopListen;
        public static ServerSock[] serverSock = new ServerSock[256];
        public static ClientSock clientSock = new ClientSock();
        public static TcpListener tcpListener;
        public static IPAddress serverListenIP = IPAddress.Any;
        public static IPAddress serverIP = IPAddress.Any;
        public static int serverPort = 7777;
        public static bool disconnect;
        public static string password = "";
        public static string banFile = "banlist.txt";
        public static bool spamCheck;
        public static bool anyClients;
        public static bool ServerUp;
        public static int connectionLimit;
        public static bool killInactive;

        public static void ResetNetDiag()
        {
            Main.rxMsg = 0;
            Main.rxData = 0;
            Main.txMsg = 0;
            Main.txData = 0;
            for (int i = 0; i < Main.maxMsg; i++)
            {
                Main.rxMsgType[i] = 0;
                Main.rxDataType[i] = 0;
                Main.txMsgType[i] = 0;
                Main.txDataType[i] = 0;
            }
        }

        public static void ResetSections()
        {
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < Main.maxSectionsX; j++)
                {
                    for (int k = 0; k < Main.maxSectionsY; k++)
                    {
                        serverSock[i].tileSection[j, k] = false;
                    }
                }
            }
        }

        public static void AddBan(int plr)
        {
            string text = serverSock[plr].Socket.RemoteEndPoint.ToString();
            string value = text;
            for (int i = 0; i < text.Length; i++)
            {
                if (text.Substring(i, 1) == ":")
                {
                    value = text.Substring(0, i);
                }
            }
            using (var streamWriter = new StreamWriter(banFile, true))
            {
                streamWriter.WriteLine("//" + Main.player[plr].name);
                streamWriter.WriteLine(value);
            }
        }

        public static bool CheckBan(string ip)
        {
            try
            {
                string b = ip;
                for (int i = 0; i < ip.Length; i++)
                {
                    if (ip.Substring(i, 1) == ":")
                    {
                        b = ip.Substring(0, i);
                    }
                }
                if (File.Exists(banFile))
                {
                    using (var streamReader = new StreamReader(banFile))
                    {
                        string a;
                        while ((a = streamReader.ReadLine()) != null)
                        {
                            if (a == b)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch
            {
            }
            return false;
        }

        public static void newRecent()
        {
            for (int i = 0; i < Main.maxMP; i++)
            {
                if (Main.recentIP[i] == serverIP.ToString() && Main.recentPort[i] == serverPort)
                {
                    for (int j = i; j < Main.maxMP - 1; j++)
                    {
                        Main.recentIP[j] = Main.recentIP[j + 1];
                        Main.recentPort[j] = Main.recentPort[j + 1];
                        Main.recentWorld[j] = Main.recentWorld[j + 1];
                    }
                }
            }
            for (int k = Main.maxMP - 1; k > 0; k--)
            {
                Main.recentIP[k] = Main.recentIP[k - 1];
                Main.recentPort[k] = Main.recentPort[k - 1];
                Main.recentWorld[k] = Main.recentWorld[k - 1];
            }
            Main.recentIP[0] = serverIP.ToString();
            Main.recentPort[0] = serverPort;
            Main.recentWorld[0] = Main.worldName;
        }

        public static void ServerLoop(object threadContext)
        {
            ResetNetDiag();
            if (Main.rand == null)
            {
                Main.rand = new Random((int) DateTime.Now.Ticks);
            }
            if (WorldGen.genRand == null)
            {
                WorldGen.genRand = new Random((int) DateTime.Now.Ticks);
            }
            Main.myPlayer = 255;
            serverIP = IPAddress.Any;
            //Netplay.serverListenIP = Netplay.serverIP;
            Main.menuMode = 14;
            Main.statusText = "Starting server...";
            Main.netMode = 2;
            disconnect = false;
            for (int i = 0; i < 256; i++)
            {
                serverSock[i] = new ServerSock();
                serverSock[i].Reset();
                serverSock[i].whoAmI = i;
                serverSock[i].Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSock[i].readBuffer = new byte[1024];
                serverSock[i].writeBuffer = new byte[1024];
            }
            tcpListener = new TcpListener(serverListenIP, serverPort);
            try
            {
                tcpListener.Start();
            }
            catch (Exception ex)
            {
                Main.menuMode = 15;
                Main.statusText = ex.ToString();
                disconnect = true;
            }
            if (!disconnect)
            {
                ThreadPool.QueueUserWorkItem(ListenForClients, 1);
                Main.statusText = "Server started";
            }
            int num = 0;
            while (!disconnect)
            {
                if (stopListen)
                {
                    int num2 = -1;
                    for (int j = 0; j < Main.maxNetPlayers; j++)
                    {
                        if (serverSock[j].Socket == null || !serverSock[j].Socket.Connected)
                        {
                            num2 = j;
                            break;
                        }
                    }
                    if (num2 >= 0)
                    {
                        if (Main.ignoreErrors)
                        {
                            try
                            {
                                tcpListener.Start();
                                stopListen = false;
                                ThreadPool.QueueUserWorkItem(ListenForClients, 1);
                                goto IL_208;
                            }
                            catch
                            {
                                goto IL_208;
                            }
                        }
                        tcpListener.Start();
                        stopListen = false;
                        ThreadPool.QueueUserWorkItem(ListenForClients, 1);
                    }
                }
                IL_208:
                int num3 = 0;
                for (int k = 0; k < 256; k++)
                {
                    if (NetMessage.buffer[k].checkBytes)
                    {
                        NetMessage.CheckBytes(k);
                    }
                    if (killInactive && serverSock[k].active && serverSock[k].state == 0 &&
                        (DateTime.UtcNow - serverSock[k].connectTime).TotalSeconds > 5)
                        serverSock[k].kill = true;

                    if (serverSock[k].kill)
                    {
                        ServerHooks.OnLeave(serverSock[k].whoAmI);
                        serverSock[k].Reset();
                        NetMessage.syncPlayers();
                    }
                    else if (serverSock[k].Socket != null && serverSock[k].Socket.Connected)
                    {
                        if (!serverSock[k].active)
                        {
                            serverSock[k].state = 0;
                        }
                        serverSock[k].active = true;
                        num3++;
                        if (!serverSock[k].locked && !serverSock[k].readPending)
                        {
                            try
                            {
                                serverSock[k].readPending = true;
                                serverSock[k].Socket.BeginReceive(serverSock[k].readBuffer, 0,
                                                                  serverSock[k].readBuffer.Length, SocketFlags.None,
                                                                  serverSock[k].ServerReadCallBack, null);
                            }
                            catch
                            {
                                serverSock[k].kill = true;
                            }
                        }
                        if (serverSock[k].statusMax > 0 && serverSock[k].statusText2 != "")
                        {
                            if (serverSock[k].statusCount >= serverSock[k].statusMax)
                            {
                                serverSock[k].statusText2 = "";
                                serverSock[k].statusMax = 0;
                                serverSock[k].statusCount = 0;
                            }
                            else
                            {
                            }
                        }
                        else
                        {
                        }
                    }
                    else if (serverSock[k].active)
                    {
                        serverSock[k].kill = true;
                    }
                    else
                    {
                        serverSock[k].statusText2 = "";
                        if (k < 255)
                        {
                            Main.player[k].active = false;
                        }
                    }
                }
                num++;
                if (num > 10)
                {
                    Thread.Sleep(1);
                    num = 0;
                }
                else
                {
                    Thread.Sleep(0);
                }
                if (num3 == 0)
                {
                    anyClients = false;
                }
                else
                {
                    anyClients = true;
                }
                ServerUp = true;
            }
            tcpListener.Stop();
            for (int l = 0; l < 256; l++)
            {
                serverSock[l].Reset();
            }
            if (Main.menuMode != 15)
            {
                Main.netMode = 0;
                Main.menuMode = 10;
                WorldGen.saveWorld(false);
                while (WorldGen.saveLock)
                {
                }
                Main.menuMode = 0;
            }
            else
            {
                Main.netMode = 0;
            }
            Main.myPlayer = 0;
        }

        public static void ListenForClients(object threadContext)
        {
            while (!disconnect && !stopListen)
            {
                int num = -1;
                for (int i = 0; i < Main.maxNetPlayers; i++)
                {
                    if (serverSock[i].Socket == null || !serverSock[i].Socket.Connected)
                    {
                        num = i;
                        break;
                    }
                }
                if (num >= 0)
                {
                    try
                    {
                        if (!tcpListener.Pending())
                        {
                            Thread.Sleep(1000);
                            continue;
                        }
                        tcpListener.BeginAcceptSocket(EndAcceptSocket, num);
                        continue;
                    }
                    catch (Exception ex)
                    {
                        if (!disconnect)
                        {
                            Main.menuMode = 15;
                            Main.statusText = ex.ToString();
                            disconnect = true;
                        }
                        continue;
                    }
                }
                stopListen = true;
                tcpListener.Stop();
            }
        }

        private static void EndAcceptSocket(IAsyncResult ar)
        {
            try
            {
                var num = (int) ar.AsyncState;
                serverSock[num].Socket = tcpListener.EndAcceptSocket(ar);
                string tmp;
                bool quick = false;
                try
                {
                    tmp = serverSock[num].Socket.RemoteEndPoint.ToString();
                }
                catch (Exception ex)
                {
                    tmp = "0.0.0.0";
                    quick = true;
                }
                serverSock[num].Socket.NoDelay = true;
                serverSock[num].connectTime = DateTime.UtcNow;
                if (quick == false)
                {
                    Console.WriteLine(tmp + " is connecting...");
                }
                else
                {
                    Console.WriteLine("Detected quick connection/disconnection on server.. disregarding.");
                }
                if (connectionLimit > 0 && CheckExistingIP(tmp.Split(':')[0]) > connectionLimit)
                    serverSock[num].kill = true;
            }
            catch (Exception)
            {
                disconnect = true;
            }
        }

        public static int CheckExistingIP(string IP)
        {
            int hit = 0;
            for (int i = 0; i < Main.maxNetPlayers; i++)
                if (serverSock[i] != null && serverSock[i].Socket.Connected &&
                    serverSock[i].Socket.RemoteEndPoint.ToString().Split(':')[0] == IP)
                    hit++;
            return hit;
        }

        public static void StartServer()
        {
            ThreadPool.QueueUserWorkItem(ServerLoop, 1);
        }

        public static bool SetIP(string newIP)
        {
            try
            {
                serverIP = IPAddress.Parse(newIP);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool SetIP2(string newIP)
        {
            bool result;
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(newIP);
                IPAddress[] addressList = hostEntry.AddressList;
                for (int i = 0; i < addressList.Length; i++)
                {
                    if (addressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        serverIP = addressList[i];
                        result = true;
                        return result;
                    }
                }
                result = false;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static void Init()
        {
            for (int i = 0; i < 257; i++)
            {
                if (i < 256)
                {
                    serverSock[i] = new ServerSock();
                    //serverSock[i].Socket.NoDelay = true;
                }
                NetMessage.buffer[i] = new messageBuffer {whoAmI = i};
            }
            clientSock.tcpClient.NoDelay = true;
        }

        public static int GetSectionX(int x)
        {
            return x/200;
        }

        public static int GetSectionY(int y)
        {
            return y/150;
        }
    }
}