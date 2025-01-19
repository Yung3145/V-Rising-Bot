using System;
using System.Runtime.CompilerServices;
using Bloodstone.API;
using Il2CppInterop.Runtime.Injection;
using UnityEngine;
using VRisingESP.ESP;
// lost key

namespace VRisingESP.Patches
{
	// Token: 0x0200000A RID: 10
	public class ESPBehaviour : MonoBehaviour
	{
		// Token: 0x06000053 RID: 83 RVA: 0x0000243C File Offset: 0x0000063C
		public static void Initialize()
		{
			if (!ClassInjector.IsTypeRegisteredInIl2Cpp<ESPBehaviour>())
			{
				ClassInjector.RegisterTypeInIl2Cpp<ESPBehaviour>();
			}
			ESPBehaviour._instance = Plugin.Instance.AddComponent<ESPBehaviour>();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002459 File Offset: 0x00000659
		private void Start()
		{
			Plugin.LogInstance.LogMessage("Starting Behaviour...");
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002B98 File Offset: 0x00000D98
		private void OnGUI()
		{
			try
			{
				Primitives.Init();
				bool isClient = VWorld.IsClient;
				if (!ESPState.IsMenuOpen)
				{
					bool espToggled = Settings.EspToggled;
					if (isClient && espToggled)
					{
						if (this._noUpdateBeforeEntityList < DateTime.Now)
						{
							this._noUpdateBeforeEntityList = DateTime.Now.AddSeconds((double)Settings.EntityListUpdateInterval);
							EntityList.UpdateEntities();
						}
						if (Settings.EspPlayers)
						{
							Render.DrawPlayers();
						}
						if (Settings.EspBloodCarriers)
						{
							Render.DrawBlood();
						}
						if (Settings.EspContainers)
						{
							Render.DrawContainers();
						}
						if (Settings.EspTraders)
						{
							Render.DrawTraders();
						}
						if (Settings.EspServants)
						{
							Render.DrawServants();
						}
						if (Settings.EspHorses)
						{
							Render.DrawHorses();
						}
						if (Settings.EspCarriages)
						{
							Render.DrawCarriages();
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000246A File Offset: 0x0000066A
		public static void Uninitialize()
		{
			UnityEngine.Object.Destroy(ESPBehaviour._instance);
			ESPBehaviour._instance = null;
		}

		// Token: 0x0400002B RID: 43
		[Nullable(2)]
		private static ESPBehaviour _instance;

		// Token: 0x0400002C RID: 44
		private DateTime _noUpdateBeforeEntityList = DateTime.MinValue;
	}
}
