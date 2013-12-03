using System;
using System.Runtime.InteropServices;

namespace Terraria
{
	public unsafe struct Tile
	{
		internal byte* ptr;

		internal Tile(byte* ptr)
		{
			this.ptr = ptr;
		}

		public bool active()
		{
			return (*ptr & 0x01) != 0;
		}
		public void active(bool active)
		{
			*ptr = (byte)((*ptr & 0xfe) | (*(byte*)&active));
		}
		public bool actuator()
		{
			return (*ptr & 0x40) != 0;
		}
		public void actuator(bool actuator)
		{
			*ptr = (byte)((*ptr & 0xbf) | (*(byte*)&actuator << 6));
		}
		public bool checkingLiquid()
		{
			return (*ptr & 0x02) != 0;
		}
		public void checkingLiquid(bool checkingLiquid)
		{
			*ptr = (byte)((*ptr & 0xfd) | (*(byte*)&checkingLiquid << 1));
		}
		public byte color()
		{
			return (byte)((*(ptr + 1) >> 2) & 0x1f);
		}
		public void color(byte color)
		{
			*(ptr + 1) = (byte)((*(ptr + 1) & 0x83) | (*(byte*)&color << 2));
		}
		public byte frameNumber()
		{
			return (byte)(*(ptr + 3) & 0x03);
		}
		public void frameNumber(byte frameNumber)
		{
			*(ptr + 3) = (byte)((*(ptr + 3) & 0xfc) | frameNumber);
		}
		public short frameX()
		{
			return *(short*)(ptr + 7);
		}
		public void frameX(short frameX)
		{
			*(short*)(ptr + 7) = frameX;
		}
		public short frameY()
		{
			return *(short*)(ptr + 9);
		}
		public void frameY(short frameY)
		{
			*(short*)(ptr + 9) = frameY;
		}
		public bool halfBrick()
		{
			return (*ptr & 0x20) != 0;
		}
		public void halfBrick(bool halfBrick)
		{
			*ptr = (byte)((*ptr & 0xdf) | (*(byte*)&halfBrick << 5));
		}
		public bool honey()
		{
			return (*(ptr + 1) & 0x80) != 0;
		}
		public void honey(bool honey)
		{
			*(ptr + 1) = (byte)((*(ptr + 1) & 0x7f) | (*(byte*)&honey << 7));
		}
		public bool inActive()
		{
			return (*ptr & 0x80) != 0;
		}
		public void inActive(bool inActive)
		{
			*ptr = (byte)((*ptr & 0x7f) | (*(byte*)&inActive << 7));
		}
		public bool lava()
		{
			return (*ptr & 0x08) != 0;
		}
		public void lava(bool lava)
		{
			*ptr = (byte)((*ptr & 0xf7) | (*(byte*)&lava << 3));
		}
		public byte liquid()
		{
			return *(ptr + 6);
		}
		public void liquid(byte liquid)
		{
			*(ptr + 6) = liquid;
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
			return (*ptr & 0x81) == 0x01;
		}
		public bool skipLiquid()
		{
			return (*ptr & 0x04) != 0;
		}
		public void skipLiquid(bool skipLiquid)
		{
			*ptr = (byte)((*ptr & 0xfb) | (*(byte*)&skipLiquid << 2));
		}
		public byte slope()
		{
			return (byte)((*(ptr + 2) >> 5) & 0x03);
		}
		public void slope(byte slope)
		{
			*(ptr + 2) = (byte)((*(ptr + 2) & 0x3f) | slope << 5);
		}
		public byte type()
		{
			return *(ptr + 4);
		}
		public void type(byte type)
		{
			*(ptr + 4) = type;
		}
		public byte wall()
		{
			return *(ptr + 5);
		}
		public void wall(byte wall)
		{
			*(ptr + 5) = wall;
		}
		public byte wallColor()
		{
			return (byte)(*(ptr + 2) & 0x1f);
		}
		public void wallColor(byte wallColor)
		{
			*(ptr + 2) = (byte)((*(ptr + 2) & 0x1f) | wallColor);
		}
		public bool wire()
		{
			return (*ptr & 0x10) != 0;
		}
		public void wire(bool wire)
		{
			*ptr = (byte)((*ptr & 0xef) | (*(byte*)&wire << 4));
		}
		public bool wire2()
		{
			return (*(ptr + 1) & 0x01) != 0;
		}
		public void wire2(bool wire2)
		{
			*(ptr + 1) = (byte)((*(ptr + 1) & 0xfe) | (*(byte*)&wire2));
		}
		public bool wire3()
		{
			return (*(ptr + 1) & 0x02) != 0;
		}
		public void wire3(bool wire3)
		{
			*(ptr + 1) = (byte)((*(ptr + 1) & 0xfd) | (*(byte*)&wire3 << 1));
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
				if (this.type() != other.type())
				{
					return false;
				}
				if (Main.tileFrameImportant[(int)this.type()])
				{
					if (this.frameX() != other.frameX())
					{
						return false;
					}
					if (this.frameY() != other.frameY())
					{
						return false;
					}
				}
			}
			if (this.wall() != other.wall())
			{
				return false;
			}
			if (this.liquid() != other.liquid())
			{
				return false;
			}
			if (this.liquid() > 0)
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