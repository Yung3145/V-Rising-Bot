using System;
using UnityEngine;

// Token: 0x02000011 RID: 17
public class TerritoryMapEntry
{
	// Token: 0x06000071 RID: 113 RVA: 0x0000252D File Offset: 0x0000072D
	public void SetData(bool minimap, int globalTerritoryIndex, TerritoryMapEntry.LocalTerritoryTeamStatus teamStatus, float zoomFactor, bool hovered, Texture2D revealTexture, Vector2 centerPosWS, float width, float height)
	{
		Debug.Log(string.Format("SetData çağrıldı. TeamStatus: {0}, Blood Yüksek!", teamStatus));
	}

	// Token: 0x02000012 RID: 18
	public enum LocalTerritoryTeamStatus
	{
		// Token: 0x0400004D RID: 77
		Neutral,
		// Token: 0x0400004E RID: 78
		Enemy,
		// Token: 0x0400004F RID: 79
		Ally,
		// Token: 0x04000050 RID: 80
		AllyDecay,
		// Token: 0x04000051 RID: 81
		EnemyDecay
	}
}
