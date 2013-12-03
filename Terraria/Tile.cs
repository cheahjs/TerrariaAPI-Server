using System;
using System.Runtime.InteropServices;
namespace Terraria
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public unsafe struct Tile
	{
		internal byte header;
		internal byte header2;
		internal byte header3;
		internal byte header4;

		public byte type;
		public byte wall;
		public byte liquid;
		public short frameX;
		public short frameY;

		public bool active()
		{
			return (header & 0x01) != 0;
		}
		public void active(bool active)
		{
			header = (byte)((header & 0xfe) | (*(byte*)&active));
		}
		public bool actuator()
		{
			return (header & 0x40) != 0;
		}
		public void actuator(bool actuator)
		{
			header = (byte)((header & 0xbf) | (*(byte*)&actuator << 6));
		}
		public bool checkingLiquid()
		{
			return (header & 0x02) != 0;
		}
		public void checkingLiquid(bool checkingLiquid)
		{
			header = (byte)((header & 0xfd) | (*(byte*)&checkingLiquid << 1));
		}
		public byte color()
		{
			return (byte)((header2 >> 2) & 0x1f);
		}
		public void color(byte color)
		{
			header2 = (byte)((header2 & 0x83) | (*(byte*)&color << 2));
		}
		public byte frameNumber()
		{
			return (byte)(header3 & 0x03);
		}
		public void frameNumber(byte frameNumber)
		{
			header3 = (byte)((header3 & 0xfc) | frameNumber);
		}
		public bool halfBrick()
		{
			return (header & 0x20) != 0;
		}
		public void halfBrick(bool halfBrick)
		{
			header = (byte)((header & 0xdf) | (*(byte*)&halfBrick << 5));
		}
		public bool honey()
		{
			return (header2 & 0x80) != 0;
		}
		public void honey(bool honey)
		{
			header2 = (byte)((header2 & 0x7f) | (*(byte*)&honey << 7));
		}
		public bool inActive()
		{
			return (header & 0x80) != 0;
		}
		public void inActive(bool inActive)
		{
			header = (byte)((header & 0x7f) | (*(byte*)&inActive << 7));
		}
		public bool lava()
		{
			return (header & 0x08) != 0;
		}
		public void lava(bool lava)
		{
			header = (byte)((header & 0xf7) | (*(byte*)&lava << 3));
		}
		public byte liquidType()
		{
			if (honey())
				return 2;
			if (lava())
				return 1;
			return 0;
		}
		public void liquidType(int liquidType)
		{
			honey((liquidType & 0x02) != 0);
			lava((liquidType & 0x01) != 0);
		}
		public bool nactive()
		{
			return (header & 0x81) == 0x01;
		}
		public bool skipLiquid()
		{
			return (header & 0x04) != 0;
		}
		public void skipLiquid(bool skipLiquid)
		{
			header = (byte)((header & 0xfb) | (*(byte*)&skipLiquid << 2));
		}
		public byte slope()
		{
			return (byte)((header3 >> 5) & 0x03);
		}
		public void slope(byte slope)
		{
			header3 = (byte)((header3 & 0x3f) | slope << 5);
		}
		public byte wallColor()
		{
			return (byte)(header3 & 0x1f);
		}
		public void wallColor(byte wallColor)
		{
			header3 = (byte)((header3 & 0x1f) | wallColor);
		}
		public bool wire()
		{
			return (header & 0x10) != 0;
		}
		public void wire(bool wire)
		{
			header = (byte)((header & 0xef) | (*(byte*)&wire << 4));
		}
		public bool wire2()
		{
			return (header2 & 0x01) != 0;
		}
		public void wire2(bool wire2)
		{
			header2 = (byte)((header2 & 0xfe) | (*(byte*)&wire2));
		}
		public bool wire3()
		{
			return (header2 & 0x02) != 0;
		}
		public void wire3(bool wire3)
		{
			header2 = (byte)((header2 & 0xfd) | (*(byte*)&wire3 << 1));
		}

		public bool isTheSameAs(Tile other)
		{
			/*uint header = *(uint*)ptr & 0x04fffff9;
			uint header2 = *(uint*)other.ptr & 0x04fffff9;

			if ((header & 0x04ff7fe9) != (header2 & 0x04ff7fe9)) // Ignore honey & lava atm
				return false;

			uint data = *(uint*)(ptr + 4) & 0x00ffffff;
			uint data2 = *(uint*)(other.ptr + 4) & 0x00ffffff;

			if ((header & 0x01) != 0)
			{
				if (data != data2)
					return false;
				if (Main.tileFrameImportant[data & 0xff])
				{
					uint frame = *(uint*)(ptr + 7);
					uint frame2 = *(uint*)(other.ptr + 7);
					if (frame != frame2)
						return false;
				}
			}
			else
			{
				if ((data & 0x00ffff00) != (data2 & 0x00ffff00))
					return false;
			}*/

			if (this.active() != other.active())
			{
				return false;
			}
			if (this.active())
			{
				if (this.type != other.type)
				{
					return false;
				}
				if (Main.tileFrameImportant[(int)this.type])
				{
					if (this.frameX != other.frameX)
					{
						return false;
					}
					if (this.frameY != other.frameY)
					{
						return false;
					}
				}
			}
			if (this.wall != other.wall)
			{
				return false;
			}
			if (this.liquid != other.liquid)
			{
				return false;
			}
			if (this.liquid > 0)
			{
				if (this.lava() != other.lava())
				{
					return false;
				}
				if (this.honey() != other.honey())
				{
					return false;
				}
			}
			return this.wire() == other.wire() && this.wire2() == other.wire2() && this.wire3() == other.wire3() && this.halfBrick() == other.halfBrick() && this.actuator() == other.actuator() && this.inActive() == other.inActive() && this.wallColor() == other.wallColor() && this.color() == other.color() && this.slope() == other.slope();

		}
	}
}
