using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BloodCarrierMap
{
    public class MapManager : MonoBehaviour
    {
        public GameObject MapCanvas;
        public GameObject BloodCarrierIconPrefab;
        public RectTransform MapContainer;
        public Button ToggleMenuButton;
        public GameObject MenuPanel;

        private List<BloodCarrier> bloodCarriers;
        private bool isMenuOpen = false;

        void Start()
        {
            bloodCarriers = new List<BloodCarrier>();
            InitializeMenu();
            SpawnBloodCarriers();
        }

        void Update()
        {
            UpdateMapIcons();
        }

        private void InitializeMenu()
        {
            ToggleMenuButton.onClick.AddListener(() =>
            {
                isMenuOpen = !isMenuOpen;
                MenuPanel.SetActive(isMenuOpen);
            });
        }

        private void SpawnBloodCarriers()
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 position = new Vector3(UnityEngine.Random.Range(-50, 50), 0, UnityEngine.Random.Range(-50, 50));
                float bloodQuality = UnityEngine.Random.Range(90f, 100f);
                bloodCarriers.Add(new BloodCarrier(position, bloodQuality));
            }
        }

        private void UpdateMapIcons()
        {
            foreach (Transform child in MapContainer)
            {
                Destroy(child.gameObject);
            }

            foreach (var carrier in bloodCarriers)
            {
                if (carrier.BloodQuality > 99.0f && !IsBehindCamera(carrier.Position))
                {
                    Vector2 mapPosition = WorldToMapPosition(carrier.Position);
                    GameObject icon = Instantiate(BloodCarrierIconPrefab, MapContainer);
                    icon.GetComponent<RectTransform>().anchoredPosition = mapPosition;
                }
            }
        }

        private Vector2 WorldToMapPosition(Vector3 worldPosition)
        {
            float mapWidth = MapContainer.rect.width;
            float mapHeight = MapContainer.rect.height;

            float normalizedX = (worldPosition.x + 50) / 100f;
            float normalizedY = (worldPosition.z + 50) / 100f;

            return new Vector2(normalizedX * mapWidth, normalizedY * mapHeight);
        }

        private bool IsBehindCamera(Vector3 position)
        {
            Vector3 screenPoint = Camera.main.WorldToViewportPoint(position);
            return screenPoint.z < 0;
        }
    }

    public class BloodCarrier
    {
        public Vector3 Position { get; private set; }
        public float BloodQuality { get; private set; }

        public BloodCarrier(Vector3 position, float bloodQuality)
        {
            Position = position;
            BloodQuality = bloodQuality;
        }
    }
}
