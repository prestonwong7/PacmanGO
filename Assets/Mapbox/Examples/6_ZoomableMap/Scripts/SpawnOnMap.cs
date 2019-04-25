namespace Mapbox.Examples
{
    using UnityEngine;
    using Mapbox.Unity.Location;
    using Mapbox.Utils;
    using Mapbox.Unity.Map;
    using Mapbox.Unity.MeshGeneration.Factories;
    using Mapbox.Unity.Utilities;
    using System.Collections.Generic;
    using System;
    using UnityEngine.UI;

    public class SpawnOnMap : MonoBehaviour
    {
        [SerializeField]
        AbstractMap _map;

        [SerializeField]
        [Geocode]
        string[] _locationStrings;
        Vector2d[] _locations;

        [SerializeField]
        float _spawnScale = 100f;

        [SerializeField]
        GameObject _markerPrefab;
        List<GameObject> _spawnedObjects;

        public PositionWithLocationProvider playerPosition;
        public Text pelletsCollectedText;
        public Text pelletsRemainingText;

        int pelletsCollected = 0;
        int pelletsRemaining = 0;
        bool pelletCountCheck = false;

        void Start()
        {
            _locations = new Vector2d[_locationStrings.Length];
            
            _spawnedObjects = new List<GameObject>();
            //location = new List<Vector2d>(_locations);
            for (int i = 0; i < _locationStrings.Length; i++)
            {
                var locationString = _locationStrings[i];
                _locations[i] = Conversions.StringToLatLon(locationString);
                var instance = Instantiate(_markerPrefab);
                instance.transform.localPosition = _map.GeoToWorldPosition(_locations[i], true);
                instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
                _spawnedObjects.Add(instance);
            }
        }

        private void Update()
        {
            int count = _spawnedObjects.Count;
            if (pelletCountCheck == false)
            {
                pelletsRemaining = count;
            }
            pelletCountCheck = true;
            playerPosition.GetComponent<PositionWithLocationProvider>();
            for (int i = 0; i < count; i++)
            {
                var spawnedObject = _spawnedObjects[i];
                var location = _locations[i];
                spawnedObject.transform.localPosition = _map.GeoToWorldPosition(location, true);
                spawnedObject.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
                //double x = Math.Pow(playerPosition._locationProvider.CurrentLocation.LatitudeLongitude.x - _locations[i].x, 2);
                //double y = Math.Pow(playerPosition._locationProvider.CurrentLocation.LatitudeLongitude.y - _locations[i].y, 2);
                float x = Vector3.Distance(playerPosition._locationProvider.CurrentLocation.LatitudeLongitude.ToVector3xz(), _locations[i].ToVector3xz());
                //double final = Math.Sqrt(x + y);
                //Debug.Log("distanceformula: " + x);
                if (x < 0.00006)
                {
                    _spawnedObjects.Remove(spawnedObject);
                    Vector2d[] temp = new Vector2d[_locations.Length - 1];
                    for(int j = 0; j < temp.Length; j++)
                    {
                        if (j < i)
                            temp[j] = _locations[j];
                        else
                            temp[j] = _locations[j + 1];
                    }
                    _locations = temp;
                    //_locations[i] = new Vector2d(0,0);
                    pelletsCollected++;
                    pelletsRemaining--;
                    Destroy(spawnedObject);
                }
                pelletsCollectedText.text = "Pellets Collected: " + pelletsCollected;
                pelletsRemainingText.text = "Pellets Remaining: " + pelletsRemaining;

            }
        }

        
    }
}