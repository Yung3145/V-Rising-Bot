using System;
using Silkworm.API;
using Silkworm.Core.Options;
using VRisingESP.Enums;

namespace VRisingESP
{
	// Token: 0x02000008 RID: 8
	internal static class Settings
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002115 File Offset: 0x00000315
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002121 File Offset: 0x00000321
		internal static bool EspToggled
		{
			get
			{
				return Settings.EspToggledOption.Value;
			}
			set
			{
				Settings.EspToggledOption.SetValue(value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000212E File Offset: 0x0000032E
		// (set) Token: 0x06000014 RID: 20 RVA: 0x0000213A File Offset: 0x0000033A
		internal static bool EspPlayers
		{
			get
			{
				return Settings.EspPlayersOption.Value;
			}
			set
			{
				Settings.EspPlayersOption.SetValue(value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002147 File Offset: 0x00000347
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002153 File Offset: 0x00000353
		internal static bool EspBloodCarriers
		{
			get
			{
				return Settings.EspBloodCarriersOption.Value;
			}
			set
			{
				Settings.EspBloodCarriersOption.SetValue(value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000216C File Offset: 0x0000036C
		internal static bool EspContainers
		{
			get
			{
				return Settings.EspContainersOption.Value;
			}
			set
			{
				Settings.EspContainersOption.SetValue(value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002179 File Offset: 0x00000379
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002185 File Offset: 0x00000385
		internal static bool EspTraders
		{
			get
			{
				return Settings.EspTradersOption.Value;
			}
			set
			{
				Settings.EspTradersOption.SetValue(value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002192 File Offset: 0x00000392
		// (set) Token: 0x0600001C RID: 28 RVA: 0x0000219E File Offset: 0x0000039E
		internal static bool EspServants
		{
			get
			{
				return Settings.EspServantsOption.Value;
			}
			set
			{
				Settings.EspServantsOption.SetValue(value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000021AB File Offset: 0x000003AB
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000021B7 File Offset: 0x000003B7
		internal static bool EspHorses
		{
			get
			{
				return Settings.EspHorsesOption.Value;
			}
			set
			{
				Settings.EspHorsesOption.SetValue(value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000021C4 File Offset: 0x000003C4
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000021D0 File Offset: 0x000003D0
		internal static bool EspCarriages
		{
			get
			{
				return Settings.EspCarriagesOption.Value;
			}
			set
			{
				Settings.EspCarriagesOption.SetValue(value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000021DD File Offset: 0x000003DD
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000021E9 File Offset: 0x000003E9
		internal static bool ShowEspBox
		{
			get
			{
				return Settings.ShowEspBoxOption.Value;
			}
			set
			{
				Settings.ShowEspBoxOption.SetValue(value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000021F6 File Offset: 0x000003F6
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002202 File Offset: 0x00000402
		internal static bool CombineAllHorseStats
		{
			get
			{
				return Settings.CombineAllHorseStatsOption.Value;
			}
			set
			{
				Settings.CombineAllHorseStatsOption.SetValue(value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0000220F File Offset: 0x0000040F
		// (set) Token: 0x06000026 RID: 38 RVA: 0x0000221B File Offset: 0x0000041B
		internal static float EntityListUpdateInterval
		{
			get
			{
				return Settings.EntityListUpdateIntervalOption.Value;
			}
			set
			{
				Settings.EntityListUpdateIntervalOption.SetValue(value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002228 File Offset: 0x00000428
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002234 File Offset: 0x00000434
		internal static float MaxRenderDistanceForPlayers
		{
			get
			{
				return Settings.MaxRenderDistanceOptionForPlayers.Value;
			}
			set
			{
				Settings.MaxRenderDistanceOptionForPlayers.SetValue(value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002241 File Offset: 0x00000441
		// (set) Token: 0x0600002A RID: 42 RVA: 0x0000224D File Offset: 0x0000044D
		internal static float MaxRenderDistanceForBloodCarriers
		{
			get
			{
				return Settings.MaxRenderDistanceOptionForBloodCariers.Value;
			}
			set
			{
				Settings.MaxRenderDistanceOptionForBloodCariers.SetValue(value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000225A File Offset: 0x0000045A
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002266 File Offset: 0x00000466
		internal static float MaxRenderDistanceForContainers
		{
			get
			{
				return Settings.MaxRenderDistanceOptionForContainers.Value;
			}
			set
			{
				Settings.MaxRenderDistanceOptionForContainers.SetValue(value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002273 File Offset: 0x00000473
		// (set) Token: 0x0600002E RID: 46 RVA: 0x0000227F File Offset: 0x0000047F
		internal static float MaxRenderDistanceForTraders
		{
			get
			{
				return Settings.MaxRenderDistanceOptionForTraders.Value;
			}
			set
			{
				Settings.MaxRenderDistanceOptionForTraders.SetValue(value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000228C File Offset: 0x0000048C
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002298 File Offset: 0x00000498
		internal static float MaxRenderDistanceForServants
		{
			get
			{
				return Settings.MaxRenderDistanceOptionForServants.Value;
			}
			set
			{
				Settings.MaxRenderDistanceOptionForServants.SetValue(value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000022A5 File Offset: 0x000004A5
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000022B1 File Offset: 0x000004B1
		internal static float MaxRenderDistanceForHorses
		{
			get
			{
				return Settings.MaxRenderDistanceOptionForHorses.Value;
			}
			set
			{
				Settings.MaxRenderDistanceOptionForHorses.SetValue(value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000022BE File Offset: 0x000004BE
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000022CA File Offset: 0x000004CA
		internal static float MaxRenderDistanceForCarriages
		{
			get
			{
				return Settings.MaxRenderDIstanceOptionForCarriages.Value;
			}
			set
			{
				Settings.MaxRenderDIstanceOptionForCarriages.SetValue(value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000022D7 File Offset: 0x000004D7
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000022E3 File Offset: 0x000004E3
		internal static bool IgnoreDistanceForPlayers
		{
			get
			{
				return Settings.IgnoreDistanceForPlayersOption.Value;
			}
			set
			{
				Settings.IgnoreDistanceForPlayersOption.SetValue(value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000022F0 File Offset: 0x000004F0
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000022FC File Offset: 0x000004FC
		internal static bool IgnoreDistanceForMaxStatHorse
		{
			get
			{
				return Settings.IgnoreDistanceForMaxStatHorseOption.Value;
			}
			set
			{
				Settings.IgnoreDistanceForMaxStatHorseOption.SetValue(value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002309 File Offset: 0x00000509
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002315 File Offset: 0x00000515
		internal static bool IgnoreDistanceFor100BloodQuality
		{
			get
			{
				return Settings.IgnoreDistanceFor100BloodQualityOption.Value;
			}
			set
			{
				Settings.IgnoreDistanceFor100BloodQualityOption.SetValue(value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002322 File Offset: 0x00000522
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000232E File Offset: 0x0000052E
		internal static float MinBloodQuality
		{
			get
			{
				return Settings.MinBloodQualityOption.Value;
			}
			set
			{
				Settings.MinBloodQualityOption.SetValue(value);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000233B File Offset: 0x0000053B
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002347 File Offset: 0x00000547
		internal static float MinMaxSpeed
		{
			get
			{
				return Settings.MinMaxSpeedOption.Value;
			}
			set
			{
				Settings.MinMaxSpeedOption.SetValue(value);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002354 File Offset: 0x00000554
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002360 File Offset: 0x00000560
		internal static float MinAcceleration
		{
			get
			{
				return Settings.MinAccelerationOption.Value;
			}
			set
			{
				Settings.MinAccelerationOption.SetValue(value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000236D File Offset: 0x0000056D
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002379 File Offset: 0x00000579
		internal static float MinRotationSpeed
		{
			get
			{
				return Settings.MinRotationSpeedOption.Value;
			}
			set
			{
				Settings.MinRotationSpeedOption.SetValue(value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002386 File Offset: 0x00000586
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002392 File Offset: 0x00000592
		internal static Colors PlayerColor
		{
			get
			{
				return (Colors)Settings.PlayerColorOption.Value;
			}
			set
			{
				Settings.PlayerColorOption.SetValue((int)value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000239F File Offset: 0x0000059F
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000023AB File Offset: 0x000005AB
		internal static Colors BloodCarrierColor
		{
			get
			{
				return (Colors)Settings.BloodCarrierColorOption.Value;
			}
			set
			{
				Settings.BloodCarrierColorOption.SetValue((int)value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000023B8 File Offset: 0x000005B8
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000023C4 File Offset: 0x000005C4
		internal static Colors ContainerColor
		{
			get
			{
				return (Colors)Settings.ContainerColorOption.Value;
			}
			set
			{
				Settings.ContainerColorOption.SetValue((int)value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000023D1 File Offset: 0x000005D1
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000023DD File Offset: 0x000005DD
		internal static Colors TraderColor
		{
			get
			{
				return (Colors)Settings.TraderColorOption.Value;
			}
			set
			{
				Settings.TraderColorOption.SetValue((int)value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000023EA File Offset: 0x000005EA
		// (set) Token: 0x0600004C RID: 76 RVA: 0x000023F6 File Offset: 0x000005F6
		internal static Colors ServantColor
		{
			get
			{
				return (Colors)Settings.ServantColorOption.Value;
			}
			set
			{
				Settings.ServantColorOption.SetValue((int)value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002403 File Offset: 0x00000603
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000240F File Offset: 0x0000060F
		internal static Colors HorseColor
		{
			get
			{
				return (Colors)Settings.HorseColorOption.Value;
			}
			set
			{
				Settings.HorseColorOption.SetValue((int)value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000241C File Offset: 0x0000061C
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002428 File Offset: 0x00000628
		internal static Colors CarriageColor
		{
			get
			{
				return (Colors)Settings.CarriageColorOption.Value;
			}
			set
			{
				Settings.CarriageColorOption.SetValue((int)value);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002435 File Offset: 0x00000635
		internal static void Init()
		{
			Settings.SetupOptions();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000272C File Offset: 0x0000092C
		private static void SetupOptions()
		{
			OptionCategory optionCategory = OptionsManager.AddCategory("VRisingESP");
			optionCategory.AddDivider("ESP toggles");
			Settings.EspToggledOption = optionCategory.AddToggle("enable ESP", "Enable ESP", true);
			Settings.EspPlayersOption = optionCategory.AddToggle("enable PlayerESP", "Show Players in ESP", true);
			Settings.EspBloodCarriersOption = optionCategory.AddToggle("enable BloodCarrierESP", "Show Blood Carriers in ESP", true);
			Settings.EspContainersOption = optionCategory.AddToggle("enable ContainerESP", "Show Containers in ESP", true);
			Settings.EspTradersOption = optionCategory.AddToggle("enable TraderESP", "Show Traders in ESP", true);
			Settings.EspServantsOption = optionCategory.AddToggle("enable ServantESP", "Show Servants in ESP", true);
			Settings.EspHorsesOption = optionCategory.AddToggle("enable HorseESP", "Show Horses in ESP", true);
			Settings.EspCarriagesOption = optionCategory.AddToggle("enable CarriageESP", "Show Carriages in ESP", true);
			Settings.ShowEspBoxOption = optionCategory.AddToggle("show EspBox", "Show ESP Box", true);
			Settings.CombineAllHorseStatsOption = optionCategory.AddToggle("CombineAllHorseStats", "Checks if all horse stats are above minimum instead of only one", true);
			optionCategory.AddDivider("Interval");
			Settings.EntityListUpdateIntervalOption = optionCategory.AddSlider("EntityList UpdateInterval", "Entity List Update Interval in seconds this is not the ESP update interval, this is how often the entity list is updated", 1f, 10f, 5f, 0, 1f);
			optionCategory.AddDivider("Distance");
			Settings.MaxRenderDistanceOptionForPlayers = optionCategory.AddSlider("Max Render Distance For Players", "Max Render Distance For Players", 10f, float.MaxValue, float.MaxValue, 0, 100f);
			Settings.MaxRenderDistanceOptionForBloodCariers = optionCategory.AddSlider("MaxRenderDistanceForBloodCarriers", "Max Render Distance For Blood Carriers", 10f, float.MaxValue, float.MaxValue, 0, 100f);
			Settings.MaxRenderDistanceOptionForContainers = optionCategory.AddSlider("MaxRenderDistanceForContainers", "Max Render Distance For Containers", 10f, 1000f, 300f, 0, 100f);
			Settings.MaxRenderDistanceOptionForTraders = optionCategory.AddSlider("MaxRenderDistanceForTraders", "Max Render Distance For Traders", 100f, 1000f, 300f, 0, 100f);
			Settings.MaxRenderDistanceOptionForServants = optionCategory.AddSlider("MaxRenderDistanceForServants", "Max Render Distance For Servants", 10f, 1000f, 300f, 0, 100f);
			Settings.MaxRenderDistanceOptionForHorses = optionCategory.AddSlider("MaxRenderDistanceForHorses", "Max Render Distance For Horses", 10f, 1000f, 300f, 0, 100f);
			Settings.MaxRenderDIstanceOptionForCarriages = optionCategory.AddSlider("MaxRenderDistanceForCarriages", "Max Render Distance For Carriages", 10f, float.MaxValue, float.MaxValue, 0, 100f);
			Settings.IgnoreDistanceForPlayersOption = optionCategory.AddToggle("IgnoreDistanceForPlayers", "Ignore Distance for Players", false);
			Settings.IgnoreDistanceForMaxStatHorseOption = optionCategory.AddToggle("IgnoreDistanceForMaxStatHorse", "Ignore Distance for Max Stat Horse", false);
			Settings.IgnoreDistanceFor100BloodQualityOption = optionCategory.AddToggle("IgnoreDistanceFor100BloodQuality", "Ignore Distance for 100 Blood Quality", true);
			optionCategory.AddDivider("Minimum stat options");
			Settings.MinBloodQualityOption = optionCategory.AddSlider("Min Blood Quality", "Minimum Blood Quality", 0f, 100f, 92f, 0, 1f);
			Settings.MinMaxSpeedOption = optionCategory.AddSlider("Min MaxSpeed", "Minimum Max Speed", 8f, 11f, 9f, 0, 0.5f);
			Settings.MinAccelerationOption = optionCategory.AddSlider("Min Acceleration", "Minimum Acceleration", 3f, 7f, 6f, 0, 0.5f);
			Settings.MinRotationSpeedOption = optionCategory.AddSlider("MinRotationSpeed", "Minimum Rotation Speed", 120f, 140f, 130f, 0, 0.5f);
			optionCategory.AddDivider("Color options");
			Settings.PlayerColorOption = optionCategory.AddDropdown("Player ESP Color", "Color of the player ESP", 1, Enum.GetNames(typeof(Colors)));
			Settings.BloodCarrierColorOption = optionCategory.AddDropdown("Blood Carrier ESP Color", "Color of the Blood Carrier ESP", 0, Enum.GetNames(typeof(Colors)));
			Settings.ContainerColorOption = optionCategory.AddDropdown("Container ESP Color", "Color of the Container ESP", 3, Enum.GetNames(typeof(Colors)));
			Settings.TraderColorOption = optionCategory.AddDropdown("Trader ESP Color", "Color of the Trader ESP", 17, Enum.GetNames(typeof(Colors)));
			Settings.ServantColorOption = optionCategory.AddDropdown("Servant ESP Color", "Color of the Servant ESP", 16, Enum.GetNames(typeof(Colors)));
			Settings.HorseColorOption = optionCategory.AddDropdown("Horse ESP Color", "Color of the Horse ESP", 4, Enum.GetNames(typeof(Colors)));
			Settings.CarriageColorOption = optionCategory.AddDropdown("Carriage ESP Color", "Color of the Carriage ESP", 15, Enum.GetNames(typeof(Colors)));
		}

		// Token: 0x04000008 RID: 8
		private static ToggleOption EspToggledOption;

		// Token: 0x04000009 RID: 9
		private static SliderOption EntityListUpdateIntervalOption;

		// Token: 0x0400000A RID: 10
		private static SliderOption MaxRenderDistanceOptionForPlayers;

		// Token: 0x0400000B RID: 11
		private static SliderOption MaxRenderDistanceOptionForBloodCariers;

		// Token: 0x0400000C RID: 12
		private static SliderOption MaxRenderDistanceOptionForContainers;

		// Token: 0x0400000D RID: 13
		private static SliderOption MaxRenderDistanceOptionForTraders;

		// Token: 0x0400000E RID: 14
		private static SliderOption MaxRenderDistanceOptionForServants;

		// Token: 0x0400000F RID: 15
		private static SliderOption MaxRenderDistanceOptionForHorses;

		// Token: 0x04000010 RID: 16
		private static SliderOption MaxRenderDIstanceOptionForCarriages;

		// Token: 0x04000011 RID: 17
		private static ToggleOption IgnoreDistanceForPlayersOption;

		// Token: 0x04000012 RID: 18
		private static ToggleOption IgnoreDistanceForMaxStatHorseOption;

		// Token: 0x04000013 RID: 19
		private static ToggleOption IgnoreDistanceFor100BloodQualityOption;

		// Token: 0x04000014 RID: 20
		private static SliderOption MinBloodQualityOption;

		// Token: 0x04000015 RID: 21
		private static SliderOption MinMaxSpeedOption;

		// Token: 0x04000016 RID: 22
		private static SliderOption MinAccelerationOption;

		// Token: 0x04000017 RID: 23
		private static SliderOption MinRotationSpeedOption;

		// Token: 0x04000018 RID: 24
		private static ToggleOption EspPlayersOption;

		// Token: 0x04000019 RID: 25
		private static ToggleOption EspBloodCarriersOption;

		// Token: 0x0400001A RID: 26
		private static ToggleOption EspContainersOption;

		// Token: 0x0400001B RID: 27
		private static ToggleOption EspTradersOption;

		// Token: 0x0400001C RID: 28
		private static ToggleOption EspServantsOption;

		// Token: 0x0400001D RID: 29
		private static ToggleOption EspHorsesOption;

		// Token: 0x0400001E RID: 30
		private static ToggleOption EspCarriagesOption;

		// Token: 0x0400001F RID: 31
		private static ToggleOption ShowEspBoxOption;

		// Token: 0x04000020 RID: 32
		private static ToggleOption CombineAllHorseStatsOption;

		// Token: 0x04000021 RID: 33
		private static DropdownOption PlayerColorOption;

		// Token: 0x04000022 RID: 34
		private static DropdownOption BloodCarrierColorOption;

		// Token: 0x04000023 RID: 35
		private static DropdownOption ContainerColorOption;

		// Token: 0x04000024 RID: 36
		private static DropdownOption TraderColorOption;

		// Token: 0x04000025 RID: 37
		private static DropdownOption ServantColorOption;

		// Token: 0x04000026 RID: 38
		private static DropdownOption HorseColorOption;

		// Token: 0x04000027 RID: 39
		private static DropdownOption CarriageColorOption;
	}
}
