using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using ProjectM;
using VrisingESP.ESP.Entity; // maybe entities i forgot[check]

// Token: 0x02000013 RID: 19
public class ESPSystem
{
	
	// Token: 0x06000073 RID: 115 RVA: 0x000043A4 File Offset: 0x000025A4
	private void HighlightHighBloodTerritories(EntityManager entityManager, NativeArray<Entity> territoryEntities, float bloodThreshold = 0.92f)
	{
		for (int i = 0; i < territoryEntities.Length; i++)
		{
			Entity territoryEntity = territoryEntities[i];
			float bloodPercentForTerritory = this.GetBloodPercentForTerritory(entityManager, territoryEntity);
			TerritoryMapEntry territoryMapEntryForEntity = this.GetTerritoryMapEntryForEntity(entityManager, territoryEntity);
			if (territoryMapEntryForEntity != null)
			{
				if (bloodPercentForTerritory >= bloodThreshold)
				{
					territoryMapEntryForEntity.SetData(false, 0, TerritoryMapEntry.LocalTerritoryTeamStatus.Enemy, 1f, false, null, new Vector2(100f, 100f), 200f, 200f);
				}
				else
				{
					territoryMapEntryForEntity.SetData(false, 0, TerritoryMapEntry.LocalTerritoryTeamStatus.Neutral, 1f, false, null, new Vector2(100f, 100f), 200f, 200f);
				}
			}
		}
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002549 File Offset: 0x00000749
	private float GetBloodPercentForTerritory(EntityManager entityManager, Entity territoryEntity)
	{
		return 0.95f;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002550 File Offset: 0x00000750
	private TerritoryMapEntry GetTerritoryMapEntryForEntity(EntityManager entityManager, Entity territoryEntity)
	{
		return new TerritoryMapEntry();
	}
}
