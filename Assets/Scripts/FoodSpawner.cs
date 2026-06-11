using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _foodPrefabs = new List<GameObject>();
    [SerializeField] private Transform _spawnPoint;

    private GameObject _currentFood;

    private void Start()
    {
        SpawnFood();
    }

    private void Update()
    {
        if (_currentFood == null)
        {
            SpawnFood();
        }
    }

    private void SpawnFood()
    {
        if (_foodPrefabs.Count == 0)
        {
            print("Geen food prefabs ingevuld in de lijst.");
            return;
        }

        int randomIndex = Random.Range(0, _foodPrefabs.Count);
        GameObject prefabToSpawn = _foodPrefabs[randomIndex];

        Vector3 spawnPosition = _spawnPoint != null ? _spawnPoint.position : transform.position;
        _currentFood = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }
}