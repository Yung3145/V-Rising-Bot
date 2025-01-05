using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using BepInEx;
using BepInEx.Core.Logging.Interpolation;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using Bloodstone.API;
using HarmonyLib;
using VRisingESP.Patches;

namespace VRisingESP
{
	// Token: 0x02000007 RID: 7
	[NullableContext(1)]
	[Nullable(0)]
	[BepInPlugin("ESP", "ESP", "1.0.0")]
	[BepInProcess("VRising.exe")]
	[BepInDependency("gg.deca.Bloodstone", BepInDependency.DependencyFlags.HardDependency)]
	[BepInDependency("iZastic.Silkworm", BepInDependency.DependencyFlags.HardDependency)]
	[Reloadable]
	public class Plugin : BasePlugin, IRunOnInitialized
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020C7 File Offset: 0x000002C7
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000020CE File Offset: 0x000002CE
		public static Plugin Instance { get; private set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020D6 File Offset: 0x000002D6
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000020DD File Offset: 0x000002DD
		public static ManualLogSource LogInstance { get; private set; }

		// Token: 0x0600000C RID: 12 RVA: 0x00002634 File Offset: 0x00000834
		public sealed override void Load()
		{
			bool flag;
			if (!VWorld.IsClient)
			{
				ManualLogSource log = base.Log;
				BepInExWarningLogInterpolatedStringHandler bepInExWarningLogInterpolatedStringHandler = new BepInExWarningLogInterpolatedStringHandler(32, 0, ref flag);
				if (flag)
				{
					bepInExWarningLogInterpolatedStringHandler.AppendLiteral("This plugin is client-side only!");
				}
				log.LogWarning(bepInExWarningLogInterpolatedStringHandler);
				return;
			}
			Plugin.LogInstance = base.Log;
			Plugin.Instance = this;
			Settings.Init();
			this._harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), null);
			ManualLogSource log2 = base.Log;
			BepInExInfoLogInterpolatedStringHandler bepInExInfoLogInterpolatedStringHandler = new BepInExInfoLogInterpolatedStringHandler(19, 2, ref flag);
			if (flag)
			{
				bepInExInfoLogInterpolatedStringHandler.AppendLiteral("Plugin ");
				bepInExInfoLogInterpolatedStringHandler.AppendFormatted<string>("ESP");
				bepInExInfoLogInterpolatedStringHandler.AppendLiteral(" ");
				bepInExInfoLogInterpolatedStringHandler.AppendFormatted<string>("1.0.0");
				bepInExInfoLogInterpolatedStringHandler.AppendLiteral(" is loaded!");
			}
			log2.LogInfo(bepInExInfoLogInterpolatedStringHandler);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020E5 File Offset: 0x000002E5
		public void OnGameInitialized()
		{
			if (!VWorld.IsClient)
			{
				return;
			}
			Plugin.InitializeAfterLoaded();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000026E8 File Offset: 0x000008E8
		internal static void InitializeAfterLoaded()
		{
			ESPBehaviour.Initialize();
			ManualLogSource logInstance = Plugin.LogInstance;
			bool flag;
			BepInExInfoLogInterpolatedStringHandler bepInExInfoLogInterpolatedStringHandler = new BepInExInfoLogInterpolatedStringHandler(10, 1, ref flag);
			if (flag)
			{
				bepInExInfoLogInterpolatedStringHandler.AppendFormatted<string>("InitializeAfterLoaded");
				bepInExInfoLogInterpolatedStringHandler.AppendLiteral(" completed");
			}
			logInstance.LogInfo(bepInExInfoLogInterpolatedStringHandler);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020F4 File Offset: 0x000002F4
		public override bool Unload()
		{
			ESPBehaviour.Uninitialize();
			Harmony harmony = this._harmony;
			if (harmony != null)
			{
				harmony.UnpatchSelf();
			}
			return true;
		}

		// Token: 0x04000005 RID: 5
		private Harmony _harmony;
	}
}
