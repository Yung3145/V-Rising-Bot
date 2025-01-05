using System;
using UnityEngine;
using VRisingESP.Enums;

namespace VRisingESP.ESP
{
	// Token: 0x0200000C RID: 12
	public class ColorApplier
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00002C64 File Offset: 0x00000E64
		public static Color GetColor(Colors selectedColor)
		{
			Color result;
			switch (selectedColor)
			{
			case Colors.Red:
				result = Color.red;
				break;
			case Colors.Green:
				result = Color.green;
				break;
			case Colors.Blue:
				result = Color.blue;
				break;
			case Colors.Yellow:
				result = Color.yellow;
				break;
			case Colors.Cyan:
				result = Color.cyan;
				break;
			case Colors.Magenta:
				result = Color.magenta;
				break;
			case Colors.White:
				result = Color.white;
				break;
			case Colors.Black:
				result = Color.black;
				break;
			case Colors.Gray:
				result = Color.gray;
				break;
			case Colors.LightBlue:
				ColorUtility.TryParseHtmlString("#ADD8E6", out result);
				break;
			case Colors.DarkBlue:
				ColorUtility.TryParseHtmlString("#00008B", out result);
				break;
			case Colors.LightGreen:
				ColorUtility.TryParseHtmlString("#90EE90", out result);
				break;
			case Colors.DarkGreen:
				ColorUtility.TryParseHtmlString("#006400", out result);
				break;
			case Colors.LightYellow:
				ColorUtility.TryParseHtmlString("#FFFFE0", out result);
				break;
			case Colors.DarkYellow:
				ColorUtility.TryParseHtmlString("#DAA520", out result);
				break;
			case Colors.Orange:
				ColorUtility.TryParseHtmlString("#FFA500", out result);
				break;
			case Colors.Purple:
				ColorUtility.TryParseHtmlString("#800080", out result);
				break;
			case Colors.Brown:
				ColorUtility.TryParseHtmlString("#A52A2A", out result);
				break;
			case Colors.Pink:
				ColorUtility.TryParseHtmlString("#FFC0CB", out result);
				break;
			case Colors.Teal:
				ColorUtility.TryParseHtmlString("#008080", out result);
				break;
			default:
				result = Color.white;
				break;
			}
			return result;
		}
	}
}
