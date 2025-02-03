using System;
using System.Collections.Generic;
using UnityEngine;


namespace Mappy
{
    public class Mappy : MonoBehaviour
    {
        private void ClearMarkers()
        {
            foreach (GameObject obj in this.xMarkers)
            {
                Destroy(obj);
            }
            this.xMarkers.Clear();
        }

        private List<Entity> GetEntitiesWithHighBloodQuality(int minQuality)
        {
            List<Entity> allEntities = GetAllEntities(); // Tüm varlıkları almak için bir metod eklenmeli.
            List<Entity> filteredEntities = new List<Entity>();

            foreach (Entity entity in allEntities)
            {
                if (entity.BloodQuality >= minQuality)
                {
                    filteredEntities.Add(entity);
                }
            }
            return filteredEntities;
        }

        private Vector3 ConvertWorldToMinimap(Vector3 worldPosition)
        {
            if (this.minimap == null)
            {
                Debug.LogError("Minimap referansı atanmadı!");
                return Vector3.zero;
            }

            Vector3 position = this.minimap.transform.position;
            Vector3 localScale = this.minimap.transform.localScale;
            return position + new Vector3(worldPosition.x * localScale.x, worldPosition.y * localScale.y, worldPosition.z * localScale.z);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F9))
            {
                ToggleESP(); //create new one
            }
        }

        private void ToggleESP()
        {
            if (this.minimap == null)
            {
                Debug.LogError("Minimap referansı atanmadı!");
                return;
            }
            this.UpdateMarkers();
        }

        private void UpdateMarkers()
        {
            this.ClearMarkers();
            foreach (Entity entity in this.GetEntitiesWithHighBloodQuality(92))
            {
                Vector3 position = this.ConvertWorldToMinimap(entity.Position);
                this.PlaceMarker(position);
            }
        }

        private void PlaceMarker(Vector3 position)
        {
            if (this.xMarkerPrefab == null)
            {
                Debug.LogError("X işareti prefab'ı atanmadı!");
                return;
            }
            GameObject marker = Instantiate(this.xMarkerPrefab, position, Quaternion.identity, this.minimap.transform);
            this.xMarkers.Add(marker);
        }

        public GameObject minimap;
        public GameObject xMarkerPrefab;
        private List<GameObject> xMarkers = new List<GameObject>();

        public class Entity
        {
            public int BloodQuality { get; set; }
            public Vector3 Position { get; set; }

            public Entity(int bloodQuality, Vector3 position)
            {
                BloodQuality = bloodQuality;
                Position = position;
            }
        }

        private List<Entity> GetAllEntities()
        {
            // Burada gerçek oyun içi varlıkları almak için bir sistem kullanılmalı.
            return new List<Entity>
            {
                new Entity(92, new Vector3(1, 0, 2)),
            
                new Entity(99, new Vector3(-1, 0, 5)),
            };
        }
    }
}