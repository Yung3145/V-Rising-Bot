using System;
using UnityEngine;

namespace VRisingESP
{
	// Token: 0x02000006 RID: 6
	internal static class ESPState
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000209D File Offset: 0x0000029D
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000020A7 File Offset: 0x000002A7
		internal static bool IsMenuOpen
		{
			get
			{
				return ESPState._menusOpen > 0;
			}
			set
			{
				ESPState._menusOpen = (value ? (ESPState._menusOpen + 1) : Mathf.Max(0, ESPState._menusOpen - 1));
			}
		}

		// Token: 0x04000004 RID: 4
		private static int _menusOpen;
	}
}
