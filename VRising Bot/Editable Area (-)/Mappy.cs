using System;
using System.Collections.Generic;
using UnityEngine;

namespace Mappy
{
	// Token: 0x02000016 RID: 22
	public class Mappy : MonoBehaviour
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00004688 File Offset: 0x00002888
		private void ClearMarkers()
		{
			foreach (GameObject obj in this.xMarkers)
			{
				UnityEngine.Object.Destroy(obj);
			}
			this.xMarkers.Clear();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000046E4 File Offset: 0x000028E4
		private List<Mappy.Entity> GetEntitiesWithHighBloodQuality(int minQuality)
		{
			List<Mappy.Entity> list = new List<Mappy.Entity>();
			List<Mappy.Entity> list2 = new List<Mappy.Entity>();
			foreach (Mappy.Entity entity in list)
			{
				if (entity.BloodQuality >= minQuality)
				{
					list2.Add(entity);
				}
			}
			return list2;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004748 File Offset: 0x00002948
		private Vector3 ConvertWorldToMinimap(Vector3 worldPosition)
		{
			if (this.minimap == null)
			{
				Debug.LogError("Minimap referansı atanmadı!");
				return Vector3.zero;
			}
			Vector3 position = this.minimap.transform.position;
			Vector3 localScale = this.minimap.transform.localScale;
			Vector3 b = new Vector3(worldPosition.x * localScale.x, worldPosition.y * localScale.y, worldPosition.z * localScale.z);
			return position + b;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000025B5 File Offset: 0x000007B5
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.F9))
			{
				this.ToggleESP();
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000025C9 File Offset: 0x000007C9
		private void ToggleESP()
		{
			if (this.minimap == null)
			{
				Debug.LogError("Minimap referansı atanmadı!");
				return;
			}
			this.UpdateMarkers();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000047D0 File Offset: 0x000029D0
		private void UpdateMarkers()
		{
			this.ClearMarkers();
			foreach (Mappy.Entity entity in this.GetEntitiesWithHighBloodQuality(92))
			{
				Vector3 position = this.ConvertWorldToMinimap(entity.Position);
				this.PlaceMarker(position);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004838 File Offset: 0x00002A38
		private void PlaceMarker(Vector3 position)
		{
			if (this.xMarkerPrefab == null)
			{
				Debug.LogError("X işareti prefab'ı atanmadı!");
				return;
			}
			GameObject item = UnityEngine.Object.Instantiate<GameObject>(this.xMarkerPrefab, position, Quaternion.identity, this.minimap.transform);
			this.xMarkers.Add(item);
		}

		// Token: 0x04000058 RID: 88
		public GameObject minimap;

		// Token: 0x04000059 RID: 89
		public GameObject xMarkerPrefab;

		// Token: 0x0400005A RID: 90
		private List<GameObject> xMarkers = new List<GameObject>();

		// Token: 0x02000017 RID: 23
		public class Entity
		{
			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000086 RID: 134 RVA: 0x000025EF File Offset: 0x000007EF
			// (set) Token: 0x06000087 RID: 135 RVA: 0x000025F7 File Offset: 0x000007F7
			public int BloodQuality { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000088 RID: 136 RVA: 0x00002600 File Offset: 0x00000800
			// (set) Token: 0x06000089 RID: 137 RVA: 0x00002608 File Offset: 0x00000808
			public Vector3 Position { get; set; }
		}
	}
}
