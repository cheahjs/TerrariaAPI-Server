using System;
using System.ComponentModel;
using Terraria;
namespace Hooks
{
	public class NpcUseDoorEventArgs : HandledEventArgs
	{
		public NPC Npc
		{
			get;
			set;
		}
		public bool IsOpening
		{
			get;
			set;
		}
		public int X
		{
			get;
			set;
		}
		public int Y
		{
			get;
			set;
		}
	}
}
