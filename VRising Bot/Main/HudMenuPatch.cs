using System;
using HarmonyLib;
using ProjectM.UI;

namespace VRisingESP.Patches
{
	// Token: 0x0200000B RID: 11
	[HarmonyPatch]
	internal static class HUDMenu_Patch
	{
		// Token: 0x06000058 RID: 88 RVA: 0x0000248F File Offset: 0x0000068F
		[HarmonyPostfix]
		[HarmonyPatch(typeof(HUDMenu), "OnEnable")]
		private static void OnEnable()
		{
			ESPState.IsMenuOpen = true;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002497 File Offset: 0x00000697
		[HarmonyPostfix]
		[HarmonyPatch(typeof(HUDMenu), "OnDisable")]
		private static void OnDisable()
		{
			ESPState.IsMenuOpen = false;
		}
	}
}
