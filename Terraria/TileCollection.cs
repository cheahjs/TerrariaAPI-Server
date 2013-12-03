using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terraria
{
	public unsafe class TileCollection
	{
		internal TileData[] data;

		public TileCollection(int maxX, int maxY)
		{
			data = new TileData[(maxX + 1) * (maxY + 1)];
		}

		public Tile this[int x, int y]
		{
			get
			{
				fixed (TileData* ptr = &data[(y * Main.maxTilesX + x)])
					return new Tile(ptr);
			}
			set { }
		}

		public TileData GetData(int x, int y)
		{
			return data[y * Main.maxTilesX + x];
		}
		public void SetData(int x, int y, TileData data)
		{
			this.data[y * Main.maxTilesX + x] = data;
		}
	}
}