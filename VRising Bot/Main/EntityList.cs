using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bloodstone.API;
using ProjectM;
using ProjectM.Shared;
using Unity.Collections;
using Unity.Entities;

namespace VRisingESP.ESP
{
	// Token: 0x0200000D RID: 13
	[NullableContext(2)]
	[Nullable(0)]
	internal class EntityList
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00002DE4 File Offset: 0x00000FE4
		public static void UpdateEntities()
		{
			List<Entity> list = new List<Entity>();
			List<Entity> list2 = new List<Entity>();
			List<Entity> list3 = new List<Entity>();
			List<Entity> list4 = new List<Entity>();
			List<Entity> list5 = new List<Entity>();
			List<Entity> list6 = new List<Entity>();
			List<Entity> list7 = new List<Entity>();
			EntityManager entityManager = VWorld.Client.EntityManager;
			if (Settings.EspPlayers)
			{
				foreach (Entity item in entityManager.CreateEntityQuery(new ComponentType[]
				{
					ComponentType.ReadOnly<PlayerCharacter>()
				}).ToEntityArray(Allocator.Temp))
				{
					list.Add(item);
				}
				EntityList.Players = list;
			}
			if (Settings.EspBloodCarriers)
			{
				foreach (Entity entity in entityManager.CreateEntityQuery(new ComponentType[]
				{
					ComponentType.ReadOnly<BloodConsumeSource>()
				}).ToEntityArray(Allocator.Temp))
				{
					if (Math.Ceiling((double)entityManager.GetComponentData<BloodConsumeSource>(entity).BloodQuality) >= (double)Settings.MinBloodQuality)
					{
						list2.Add(entity);
					}
				}
				EntityList.BloodCarriers = list2;
			}
			if (Settings.EspContainers)
			{
				foreach (Entity item2 in entityManager.CreateEntityQuery(new EntityQueryDesc[]
				{
					new EntityQueryDesc
					{
						All = new ComponentType[]
						{
							ComponentType.ReadOnly<InventoryOwner>()
						},
						None = new ComponentType[]
						{
							ComponentType.ReadOnly<BlueprintData>(),
							ComponentType.ReadOnly<DismantleDestroyData>(),
							ComponentType.ReadOnly<TakeDamageInSun>(),
							ComponentType.ReadOnly<ServantEquipment>(),
							ComponentType.ReadOnly<Trader>()
						}
					}
				}).ToEntityArray(Allocator.Temp))
				{
					list3.Add(item2);
				}
				EntityList.Containers = list3;
			}
			if (Settings.EspTraders)
			{
				foreach (Entity item3 in entityManager.CreateEntityQuery(new EntityQueryDesc[]
				{
					new EntityQueryDesc
					{
						All = new ComponentType[]
						{
							ComponentType.ReadOnly<Trader>()
						},
						None = new ComponentType[]
						{
							ComponentType.ReadOnly<PlayerCharacter>(),
							ComponentType.ReadOnly<BlueprintData>(),
							ComponentType.ReadOnly<DismantleDestroyData>(),
							ComponentType.ReadOnly<TakeDamageInSun>()
						}
					}
				}).ToEntityArray(Allocator.Temp))
				{
					list4.Add(item3);
				}
				EntityList.Traders = list4;
			}
			if (Settings.EspServants)
			{
				foreach (Entity item4 in entityManager.CreateEntityQuery(new EntityQueryDesc[]
				{
					new EntityQueryDesc
					{
						All = new ComponentType[]
						{
							ComponentType.ReadOnly<ServantEquipment>()
						},
						None = new ComponentType[]
						{
							ComponentType.ReadOnly<PlayerCharacter>(),
							ComponentType.ReadOnly<BlueprintData>(),
							ComponentType.ReadOnly<DismantleDestroyData>(),
							ComponentType.ReadOnly<TakeDamageInSun>()
						}
					}
				}).ToEntityArray(Allocator.Temp))
				{
					list5.Add(item4);
				}
			}
			EntityList.Servants = list5;
			if (Settings.EspHorses)
			{
				foreach (Entity item5 in entityManager.CreateEntityQuery(new EntityQueryDesc[]
				{
					new EntityQueryDesc
					{
						All = new ComponentType[]
						{
							ComponentType.ReadOnly<Mountable>()
						}
					}
				}).ToEntityArray(Allocator.Temp))
				{
					list6.Add(item5);
				}
			}
			EntityList.Horses = list6;
			if (Settings.EspCarriages)
			{
				foreach (Entity item6 in entityManager.CreateEntityQuery(new EntityQueryDesc[]
				{
					new EntityQueryDesc
					{
						All = new ComponentType[]
						{
							ComponentType.ReadOnly<Script_CarriageData>()
						}
					}
				}).ToEntityArray(Allocator.Temp))
				{
					list7.Add(item6);
				}
			}
			EntityList.Carriages = list7;
		}

		// Token: 0x0400002D RID: 45
		public static List<Entity> Players;

		// Token: 0x0400002E RID: 46
		public static List<Entity> BloodCarriers;

		// Token: 0x0400002F RID: 47
		public static List<Entity> Containers;

		// Token: 0x04000030 RID: 48
		public static List<Entity> Traders;

		// Token: 0x04000031 RID: 49
		public static List<Entity> Servants;

		// Token: 0x04000032 RID: 50
		public static List<Entity> Horses;

		// Token: 0x04000033 RID: 51
		public static List<Entity> Carriages;
	}
}
