using System;
using Terraria;

namespace Hooks
{
	public static class ProjectileHooks
	{
		public delegate void TriggerPressurePlateD(ProjectileTriggerPressurePlateEventArgs e);

        public static event SetDefaultsD<Projectile, int> SetDefaults;
		public static event TriggerPressurePlateD TriggerPressurePlate;

        public static void OnSetDefaults(ref int type, Projectile proj)
        {
            if (SetDefaults == null)
            {
                return;
            }
            SetDefaultsEventArgs<Projectile, int> setDefaultsEventArgs = new SetDefaultsEventArgs<Projectile, int>
            {
                Object = proj,
                Info = type
            };
            SetDefaults(setDefaultsEventArgs);
            type = setDefaultsEventArgs.Info;
        }

		public static bool OnTriggerPressurePlate(Projectile projectile, int x, int y)
		{
			if (ProjectileHooks.TriggerPressurePlate == null)
			{
				return false;
			}
			ProjectileTriggerPressurePlateEventArgs triggerPressurePlateArgs = new ProjectileTriggerPressurePlateEventArgs
			{
				Projectile = projectile,
				X = x,
				Y = y
			};
			ProjectileHooks.TriggerPressurePlate(triggerPressurePlateArgs);
			return triggerPressurePlateArgs.Handled;
		}
	}
}
