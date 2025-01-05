using System;
using System.Runtime.CompilerServices;
using Bloodstone.API;
using ProjectM;
using Stunlock.Core;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace VRisingESP.ESP
{
	// Token: 0x0200000F RID: 15
	internal class Render
	{
		// Token: 0x06000067 RID: 103 RVA: 0x000034B8 File Offset: 0x000016B8
		public static void DrawPlayers()
		{
			EntityManager entityManager = VWorld.Game.EntityManager;
			if (EntityList.Players != null)
			{
				foreach (Entity entity in EntityList.Players)
				{
					if (entityManager.Exists(entity) && entityManager.HasComponent<LocalToWorld>(entity))
					{
						Vector3 vector = entityManager.GetComponentData<LocalToWorld>(entity).Position;
						Vector2 a = Camera.main.WorldToScreenPoint(vector);
						if (!Render.IsBehindCamera(vector) && Vector3.Distance(Camera.main.transform.position, vector) <= Settings.MaxRenderDistanceForPlayers)
						{
							Color green = Color.green;
							string label = "Oyuncu";
							if (entityManager.HasComponent<PlayerCharacter>(entity) && entityManager.HasComponent<Equipment>(entity))
							{
								PlayerCharacter componentData = entityManager.GetComponentData<PlayerCharacter>(entity);
								if (!componentData.Name.IsEmpty)
								{
									Equipment componentData2 = entityManager.GetComponentData<Equipment>(entity);
									int num = (int)(componentData2.ArmorLevel.Value + componentData2.WeaponLevel.Value + componentData2.SpellLevel.Value);
									label = string.Format("LVL:{0} - {1}", num, componentData.Name.ToString());
								}
							}
							a.y += 220f;
							Vector2 vector2 = new Vector2(50f, 150f);
							Vector2 vector3 = a - vector2 / 2f;
							Primitives.DrawBox(vector3, vector2, green, true);
							Vector2 position = vector3;
							position.x += vector2.x / 2f;
							position.y -= -40f;
							Primitives.DrawString(position, label, green, true);
						}
					}
				}
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000036A0 File Offset: 0x000018A0
		public static void DrawBlood()
		{
			EntityManager entityManager = VWorld.Game.EntityManager;
			if (EntityList.BloodCarriers != null)
			{
				foreach (Entity entity in EntityList.BloodCarriers)
				{
					if (entityManager.Exists(entity) && entityManager.HasComponent<LocalToWorld>(entity) && entityManager.HasComponent<BloodConsumeSource>(entity))
					{
						Vector3 vector = VWorld.Game.EntityManager.GetComponentData<LocalToWorld>(entity).Position;
						BloodConsumeSource componentData = VWorld.Game.EntityManager.GetComponentData<BloodConsumeSource>(entity);
						float num = componentData.BloodQuality;
						VBloodConsumeSource vbloodConsumeSource;
						bool flag = entityManager.TryGetComponentData<VBloodConsumeSource>(entity, out vbloodConsumeSource);
						if (flag)
						{
							num = 99f;
						}
						if ((Vector3.Distance(Camera.main.transform.position, vector) <= Settings.MaxRenderDistanceForBloodCarriers && (Settings.IgnoreDistanceFor100BloodQuality || Math.Round((double)num) > 99.0) && !Render.IsBehindCamera(vector)) || (flag && !Render.IsBehindCamera(vector) && Vector3.Distance(Camera.main.transform.position, vector) < Settings.MaxRenderDistanceForBloodCarriers))
						{
							string text = VWorld.Game.GetExistingSystemManaged<PrefabCollectionSystem>().PrefabGuidToNameDictionary[componentData.UnitBloodType];
							text = text.Replace("CHAR", "").Replace("_", " ");
							string label;
							if (!flag)
							{
								label = string.Format("{0} [{1}]", text, Math.Floor(Math.Round((double)num)));
							}
							else
							{
								label = string.Format("VBlood: {0} [{1}]", text, Math.Floor(Math.Round((double)num)));
							}
							Vector2 vector2 = Camera.main.WorldToScreenPoint(vector);
							Vector2 vector3 = new Vector2(40f, 80f);
							Color color = ColorApplier.GetColor(Settings.BloodCarrierColor);
							Primitives.DrawString(vector2, label, color, true);
							if (Settings.ShowEspBox)
							{
								Primitives.DrawBox(vector2 + new Vector2(0f, vector3.y * 1.5f) - vector3 / 2f, vector3, color, true);
							}
						}
						else if (!flag && num >= 92f)
						{
							Vector3 vector4 = Camera.main.WorldToViewportPoint(vector);
							if (vector4.z < 0f)
							{
								vector4.z = 0.1f;
							}
							float num2 = Mathf.Clamp(vector4.x, 0f, 1f);
							float num3 = Mathf.Clamp(vector4.y, 0f, 1f);
							Vector2 vector5 = new Vector2(num2 * (float)Screen.width, num3 * (float)Screen.height);
							Color magenta = Color.magenta;
							float num4 = 20f;
							Primitives.DrawCircle(vector5, num4, magenta, true);
							string label2 = string.Format("{0}%", Mathf.Floor(num));
							Vector2 position = vector5;
							position.y -= num4 + 20f;
							Primitives.DrawString(position, label2, magenta, true);
						}
					}
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000039E4 File Offset: 0x00001BE4
		public static void DrawContainers()
		{
			if (EntityList.Containers != null)
			{
				foreach (Entity entity in EntityList.Containers)
				{
					if (VWorld.Game.EntityManager.Exists(entity) && VWorld.Game.EntityManager.HasComponent<InventoryOwner>(entity) && VWorld.Game.EntityManager.HasComponent<Interactable>(entity) && VWorld.Game.EntityManager.HasComponent<PlacementDestroyData>(entity))
					{
						Vector3 vector = VWorld.Game.EntityManager.GetComponentData<LocalToWorld>(entity).Position;
						if (Vector3.Distance(Camera.main.transform.position, vector) <= Settings.MaxRenderDistanceForContainers && !Render.IsBehindCamera(vector))
						{
							PrefabGUID componentData = VWorld.Game.EntityManager.GetComponentData<PrefabGUID>(entity);
							string text = VWorld.Game.GetExistingSystemManaged<PrefabCollectionSystem>().PrefabGuidToNameDictionary[componentData];
							Vector2 vector2 = Camera.main.WorldToScreenPoint(vector);
							Vector2 vector3 = new Vector2(50f, 40f);
							text = text.Replace("TM_", "").Replace("_Full", "").Replace("_01", "").Replace("_02", "").Replace("_", "");
							Color color = ColorApplier.GetColor(Settings.ContainerColor);
							Primitives.DrawString(vector2, text, color, true);
							if (Settings.ShowEspBox)
							{
								Primitives.DrawBox(vector2 + new Vector2(0f, vector3.y * 1.5f) - vector3 / 2f, vector3, color, true);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003BF0 File Offset: 0x00001DF0
		public static void DrawTraders()
		{
			EntityManager entityManager = VWorld.Game.EntityManager;
			if (EntityList.Traders != null)
			{
				foreach (Entity entity in EntityList.Traders)
				{
					if (entityManager.Exists(entity))
					{
						PrefabGUID componentData = entityManager.GetComponentData<PrefabGUID>(entity);
						string text;
						VWorld.Client.GetExistingSystemManaged<PrefabCollectionSystem>().PrefabGuidToNameDictionary.TryGetValue(componentData, out text);
						Vector3 vector = entityManager.GetComponentData<LocalToWorld>(entity).Position;
						if (Vector3.Distance(Camera.main.transform.position, vector) <= Settings.MaxRenderDistanceForTraders && !Render.IsBehindCamera(vector))
						{
							text = text.Replace("CHAR_", "").Replace("_T02", "").Replace("_T01", "").Replace("_T03", "").Replace("_T04", "").Replace("_", " ").Replace("Trader ", "");
							string label = "Trader: [" + text + "]";
							Vector2 vector2 = Camera.main.WorldToScreenPoint(vector);
							Vector2 vector3 = new Vector2(40f, 100f);
							Color color = ColorApplier.GetColor(Settings.TraderColor);
							Primitives.DrawString(vector2, label, color, true);
							if (Settings.ShowEspBox)
							{
								Primitives.DrawBox(vector2 + new Vector2(0f, vector3.y * 1.5f) - vector3 / 2f, vector3, color, true);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003DD0 File Offset: 0x00001FD0
		public static void DrawServants()
		{
			EntityManager entityManager = VWorld.Game.EntityManager;
			if (EntityList.Servants != null)
			{
				foreach (Entity entity in EntityList.Servants)
				{
					ServantPower servantPower;
					if (entityManager.Exists(entity) && entityManager.TryGetComponentData<ServantPower>(entity, out servantPower))
					{
						Vector3 vector = entityManager.GetComponentData<LocalToWorld>(entity).Position;
						if (Vector3.Distance(Camera.main.transform.position, vector) <= Settings.MaxRenderDistanceForServants && !Render.IsBehindCamera(vector))
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 3);
							defaultInterpolatedStringHandler.AppendLiteral("Servant: Gearlvl:");
							defaultInterpolatedStringHandler.AppendFormatted<float>(servantPower.GearLevel);
							defaultInterpolatedStringHandler.AppendLiteral("|Expertise:");
							defaultInterpolatedStringHandler.AppendFormatted<float>(servantPower.Expertise);
							defaultInterpolatedStringHandler.AppendLiteral("|Power:");
							defaultInterpolatedStringHandler.AppendFormatted<float>(servantPower.Power);
							defaultInterpolatedStringHandler.AppendLiteral("]");
							string label = defaultInterpolatedStringHandler.ToStringAndClear();
							Vector2 vector2 = Camera.main.WorldToScreenPoint(vector);
							Vector2 vector3 = new Vector2(40f, 100f);
							Color color = ColorApplier.GetColor(Settings.ServantColor);
							Primitives.DrawString(vector2, label, color, true);
							if (Settings.ShowEspBox)
							{
								Primitives.DrawBox(vector2 + new Vector2(0f, vector3.y * 1.5f) - vector3 / 2f, vector3, color, true);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003F88 File Offset: 0x00002188
		public static void DrawHorses()
		{
			EntityManager entityManager = VWorld.Game.EntityManager;
			if (EntityList.Horses != null)
			{
				foreach (Entity entity in EntityList.Horses)
				{
					if (entityManager.Exists(entity) && entityManager.HasComponent<LocalToWorld>(entity))
					{
						Vector3 vector = VWorld.Game.EntityManager.GetComponentData<LocalToWorld>(entity).Position;
						PrefabGUID componentData = VWorld.Game.EntityManager.GetComponentData<PrefabGUID>(entity);
						string text = VWorld.Game.GetExistingSystemManaged<PrefabCollectionSystem>().PrefabGuidToNameDictionary[componentData];
						text = text.Replace("CHAR_", "").Replace("Mount_", "").Replace("_", " ");
						bool flag = Vector3.Distance(Camera.main.transform.position, vector) > Settings.MaxRenderDistanceForHorses || Render.IsBehindCamera(vector);
						Mountable componentData2 = VWorld.Game.EntityManager.GetComponentData<Mountable>(entity);
						if (!flag)
						{
							bool flag2 = componentData2.Acceleration >= 7f && componentData2.MaxSpeed >= 11f && componentData2.RotationSpeed >= 14f;
							if ((Settings.IgnoreDistanceForMaxStatHorse && flag2) || (Settings.CombineAllHorseStats && Settings.MinAcceleration <= componentData2.Acceleration && Settings.MinMaxSpeed <= componentData2.MaxSpeed && Settings.MinRotationSpeed <= componentData2.RotationSpeed) || (!Settings.CombineAllHorseStats && (Settings.MinAcceleration <= componentData2.Acceleration || Settings.MinMaxSpeed <= componentData2.MaxSpeed || Settings.MinRotationSpeed <= componentData2.RotationSpeed)))
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 4);
								defaultInterpolatedStringHandler.AppendFormatted(text);
								defaultInterpolatedStringHandler.AppendLiteral(" [A:");
								defaultInterpolatedStringHandler.AppendFormatted<float>(componentData2.Acceleration);
								defaultInterpolatedStringHandler.AppendLiteral("|S:");
								defaultInterpolatedStringHandler.AppendFormatted<float>(componentData2.MaxSpeed);
								defaultInterpolatedStringHandler.AppendLiteral("|R:");
								defaultInterpolatedStringHandler.AppendFormatted<float>(componentData2.RotationSpeed);
								defaultInterpolatedStringHandler.AppendLiteral("]");
								string label = defaultInterpolatedStringHandler.ToStringAndClear();
								Vector2 position = Camera.main.WorldToScreenPoint(vector);
								Color color = ColorApplier.GetColor(Settings.HorseColor);
								Primitives.DrawString(position, label, color, true);
							}
						}
					}
				}
			} 
		}
            // need to check again Code:247
		// Token: 0x0600006D RID: 109 RVA: 0x00004218 File Offset: 0x00002418
		public static void DrawCarriages()
		{
			EntityManager entityManager = VWorld.Game.EntityManager;
			if (EntityList.Carriages != null)
			{
				foreach (Entity entity in EntityList.Carriages)
				{
					if (entityManager.Exists(entity) && entityManager.HasComponent<LocalToWorld>(entity))
					{
						Vector3 vector = VWorld.Game.EntityManager.GetComponentData<LocalToWorld>(entity).Position;
						PrefabGUID componentData = VWorld.Game.EntityManager.GetComponentData<PrefabGUID>(entity);
						string text = VWorld.Game.GetExistingSystemManaged<PrefabCollectionSystem>().PrefabGuidToNameDictionary[componentData];
						text = text.Replace("CHAR_", "").Replace("_", " ");
						if (Vector3.Distance(Camera.main.transform.position, vector) <= Settings.MaxRenderDistanceForCarriages && !Render.IsBehindCamera(vector))
						{
							string label = text ?? "";
							Vector2 position = Camera.main.WorldToScreenPoint(vector);
							Color color = ColorApplier.GetColor(Settings.CarriageColor);
							Primitives.DrawString(position, label, color, true);
						}
					}
				}
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004364 File Offset: 0x00002564
		private static bool IsBehindCamera(Vector3 position)
		{
			Camera main = Camera.main;
			Vector3 forward = main.transform.forward;
			Vector3 rhs = position - main.transform.position;
			return Vector3.Dot(forward, rhs) < 0f;
		}
	}
}
