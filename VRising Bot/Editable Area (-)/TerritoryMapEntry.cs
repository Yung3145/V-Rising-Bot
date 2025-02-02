using System;
using UnityEngine;
using ProjectM; // Can use plt library for analysis

// Token: 0x02000011 RID: 17
public class TerritoryMapEntry
{
	// Token: 0x06000071 RID: 113 RVA: 0x0000252D File Offset: 0x0000072D
	public void SetData(bool minimap, int globalTerritoryIndex, TerritoryMapEntry.LocalTerritoryTeamStatus teamStatus, float zoomFactor, bool hovered, Texture2D revealTexture, Vector2 centerPosWS, float width, float height)
	{
		Debug.Log(string.Format("SetData çağrıldı. TeamStatus: {0}, 