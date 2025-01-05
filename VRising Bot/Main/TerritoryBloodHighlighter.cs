using System;
using ProjectM;
using Unity.Collections;
using Unity.Entities;

namespace VRisingESP.ESP
{
	// Token: 0x02000014 RID: 20
	public class TerritoryBloodHighlighter
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00002557 File Offset: 0x00000757
		private float GetBloodPercentForTerritory(EntityManager entityManager, Entity territoryEntity)
		{
			if (entityManager.HasComponent<BloodConsumeSource>(territoryEntity))
			{
				return entityManager.GetComponentData<BloodConsumeSource>(territoryEntity).BloodQuality;
			}
			return 0f;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002576 File Offset: 0x00000776
		private TerritoryMapEntry GetTerritoryMapEntryForEntity(EntityManager entityManager, Entity territoryEntity)
		{
			return null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000443C File Offset: 0x0000263C
		public void HighlightHighBloodTerritories(EntityManager entityManager, NativeArray<Entity> territoryEntities, float threshold = 92f)
		{
			foreach (Entity territoryEntity in territoryEntities)
			{
				float bloodPercentForTerritory = this.GetBloodPercentForTerritory(entityManager, territoryEntity);
				if (this.GetTerritoryMapEntryForEntity(entityManager, territoryEntity) != null)
				{
				}
			}
		}
	}
}
