using System;
using System.Collections.Generic;
using UnityEngine;

namespace VRisingESP.ESP
{
	// Token: 0x0200000E RID: 14
	internal class Primitives
	{
		// Token: 0x0600005E RID: 94 RVA: 0x000024A7 File Offset: 0x000006A7
		public static void Init()
		{
			if (Primitives._stringStyle == null)
			{
				Primitives._stringStyle = new GUIStyle(GUI.skin.label.Pointer);
				Primitives._stringStyle.font = Font.CreateDynamicFontFromOSFont("Cascadia Mono SemiBold", 12);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003244 File Offset: 0x00001444
		public static void DrawString(Vector2 position, string label, bool centered = true)
		{
			GUIContent content = new GUIContent(label);
			Vector2 vector = Primitives._stringStyle.CalcSize(content);
			position.y = (float)Screen.height - position.y;
			GUI.Label(new Rect(centered ? (position - vector / 2f) : position, vector), content);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000024DF File Offset: 0x000006DF
		public static void DrawString(Vector2 position, string label, Color color, bool centered = true)
		{
			Color color2 = GUI.color;
			GUI.color = color;
			Primitives.DrawString(position - new Vector2(0f, 20f), label, centered);
			GUI.color = color2;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000329C File Offset: 0x0000149C
		private static Texture2D CreateHollowTexture(int width, int height, Color borderColor)
		{
			Texture2D texture2D = new Texture2D(width, height, TextureFormat.ARGB32, false);
			Color[] array = texture2D.GetPixels();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = borderColor;
			}
			for (int j = 1; j < height - 1; j++)
			{
				for (int k = 1; k < width - 1; k++)
				{
					array[j * width + k] = Color.clear;
				}
			}
			texture2D.SetPixels(array);
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000331C File Offset: 0x0000151C
		public static void DrawBox(Vector2 position, Vector2 size, Color color, bool invert = true)
		{
			if (invert)
			{
				position.y = (float)Screen.height - position.y;
			}
			Texture2D texture2D;
			if (!Primitives._hollowTextures.TryGetValue(color, out texture2D))
			{
				texture2D = Primitives.CreateHollowTexture((int)size.x, (int)size.y, color);
				Primitives._hollowTextures[color] = texture2D;
			}
			GUI.DrawTexture(new Rect(position, size), texture2D);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002515 File Offset: 0x00000715
		static Primitives()
		{
			Primitives._hollowTextures = new Dictionary<Color, Texture2D>();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003380 File Offset: 0x00001580
		public static void DrawCircle(Vector2 position, float radius, Color color, bool invert = true)
		{
			if (invert)
			{
				position.y = (float)Screen.height - position.y;
			}
			Texture2D texture2D;
			if (!Primitives._circleTextures.TryGetValue(color, out texture2D))
			{
				texture2D = Primitives.CreateCircleTexture((int)radius * 2, (int)radius * 2, color);
				Primitives._circleTextures[color] = texture2D;
			}
			GUI.DrawTexture(new Rect(position - new Vector2(radius, radius), new Vector2(radius * 2f, radius * 2f)), texture2D);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000033FC File Offset: 0x000015FC
		private static Texture2D CreateCircleTexture(int width, int height, Color color)
		{
			Texture2D texture2D = new Texture2D(width, height, TextureFormat.ARGB32, false);
			Color[] array = new Color[width * height];
			Vector2 b = new Vector2((float)width / 2f, (float)height / 2f);
			float num = (float)width / 2f * ((float)width / 2f);
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					if ((new Vector2((float)j, (float)i) - b).sqrMagnitude <= num)
					{
						array[i * width + j] = color;
					}
					else
					{
						array[i * width + j] = Color.clear;
					}
				}
			}
			texture2D.SetPixels(array);
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x04000034 RID: 52
		private static GUIStyle _stringStyle;

		// Token: 0x04000035 RID: 53
		private static Dictionary<Color, Texture2D> _hollowTextures;

		// Token: 0x04000036 RID: 54
		private static Dictionary<Color, Texture2D> _circleTextures = new Dictionary<Color, Texture2D>();
	}
}
