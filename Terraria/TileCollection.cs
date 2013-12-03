using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terraria
{
	public unsafe class TileCollection
	{
		const int BYTES_PER_TILE = 11;
		internal byte[] data;

		public TileCollection(int maxX, int maxY)
		{
			data = new byte[(maxX + 1) * (maxY + 1) * BYTES_PER_TILE];
		}

		public Tile this[int x, int y]
		{
			get
			{
				fixed (byte* ptr = &data[BYTES_PER_TILE * (y * Main.maxTilesX + x)])
					return new Tile(ptr);
			}
			set { }
		}
	}
}