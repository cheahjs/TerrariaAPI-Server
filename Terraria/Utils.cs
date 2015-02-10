using System;
using System.Collections.Generic;
using System.IO;
namespace Terraria
{
	public static class Utils
	{
        public static Random Random = new Random();
		public static bool FloatIntersect(float r1StartX, float r1StartY, float r1Width, float r1Height, float r2StartX, float r2StartY, float r2Width, float r2Height)
		{
			return r1StartX <= r2StartX + r2Width && r1StartY <= r2StartY + r2Height && r1StartX + r1Width >= r2StartX && r1StartY + r1Height >= r2StartY;
		}
		public static void WriteRGB(this BinaryWriter bb, Color c)
		{
			bb.Write(c.R);
			bb.Write(c.G);
			bb.Write(c.B);
		}
		public static void WriteVector2(this BinaryWriter bb, Vector2 v)
		{
			bb.Write(v.X);
			bb.Write(v.Y);
		}
		public static Color ReadRGB(this BinaryReader bb)
		{
			return new Color((int)bb.ReadByte(), (int)bb.ReadByte(), (int)bb.ReadByte());
		}
		public static Vector2 ReadVector2(this BinaryReader bb)
		{
			return new Vector2(bb.ReadSingle(), bb.ReadSingle());
		}
		public static float ToRotation(this Vector2 v)
		{
			return (float)Math.Atan2((double)v.Y, (double)v.X);
		}
		public static Vector2 ToRotationVector2(this float f)
		{
			return new Vector2((float)Math.Cos((double)f), (float)Math.Sin((double)f));
		}
		public static Vector2 Rotate(this Vector2 spinningpoint, double radians, Vector2 center = default(Vector2))
		{
			float num = (float)Math.Cos(radians);
			float num2 = (float)Math.Sin(radians);
			Vector2 vector = spinningpoint - center;
			Vector2 result = center;
			result.X += vector.X * num - vector.Y * num2;
			result.Y += vector.X * num2 + vector.Y * num;
			return result;
		}
		public static Color Multiply(this Color firstColor, Color secondColor)
		{
			return new Color((int)((byte)((float)(firstColor.R * secondColor.R) / 255f)), (int)((byte)((float)(firstColor.G * secondColor.G) / 255f)), (int)((byte)((float)(firstColor.B * secondColor.B) / 255f)));
		}
        /// <summary>
        /// Gets an NPC by ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>NPC</returns>
        public static NPC GetNPCById(int id)
        {
            NPC npc = new NPC();
            npc.netDefaults(id);
            return npc;
        }
        /// <summary>
        /// Gets a random clear tile in range
        /// </summary>
        /// <param name="startTileX">Bound X</param>
        /// <param name="startTileY">Bound Y</param>
        /// <param name="tileXRange">Range on the X axis</param>
        /// <param name="tileYRange">Range on the Y axis</param>
        /// <param name="tileX">X location</param>
        /// <param name="tileY">Y location</param>
        public static void GetRandomClearTileWithInRange(int startTileX, int startTileY, int tileXRange, int tileYRange,
                                                  out int tileX, out int tileY)
        {
            int j = 0;
            do
            {
                if (j == 100)
                {
                    tileX = startTileX;
                    tileY = startTileY;
                    break;
                }

                tileX = startTileX + Random.Next(tileXRange * -1, tileXRange);
                tileY = startTileY + Random.Next(tileYRange * -1, tileYRange);
                j++;
            } while (TilePlacementValid(tileX, tileY) && TileSolid(tileX, tileY));
        }

        /// <summary>
        /// Determines if a tile is valid.
        /// </summary>
        /// <param name="tileX">Location X</param>
        /// <param name="tileY">Location Y</param>
        /// <returns>If the tile is valid</returns>
        public static bool TilePlacementValid(int tileX, int tileY)
        {
            return tileX >= 0 && tileX < Main.maxTilesX && tileY >= 0 && tileY < Main.maxTilesY;
        }

        /// <summary>
        /// Checks if the tile is solid.
        /// </summary>
        /// <param name="tileX">Location X</param>
        /// <param name="tileY">Location Y</param>
        /// <returns>The tile's solidity.</returns>
        public static bool TileSolid(int tileX, int tileY)
        {
            return TilePlacementValid(tileX, tileY) && Main.tile[tileX, tileY] != null &&
                Main.tile[tileX, tileY].active() && Main.tileSolid[Main.tile[tileX, tileY].type] &&
                !Main.tile[tileX, tileY].inActive() && !Main.tile[tileX, tileY].halfBrick() && Main.tile[tileX, tileY].slope() == 0;
        }
	}
}
