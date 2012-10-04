using System;
using System.ComponentModel;
using Terraria;
namespace Hooks
{
	public class TriggerPressurePlateEventArgs : HandledEventArgs
	{
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
	
	public class NpcTriggerPressurePlateEventArgs : TriggerPressurePlateEventArgs
	{
		public NPC Npc
		{
			get;
			set;
		}
	}
	
	public class ProjectileTriggerPressurePlateEventArgs : TriggerPressurePlateEventArgs
	{
		public Projectile Projectile
		{
			get;
			set;
		}
	}
}
