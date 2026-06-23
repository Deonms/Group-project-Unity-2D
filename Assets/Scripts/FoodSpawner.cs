using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _foodPrefabs = new List<GameObject>();
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private int _maxSpawning = 1;

    private List<GameObject> _spawnedFood = new List<GameObject>();

    private void Start()
    {
        SpawnFood();
    }

    private void Update()
    {
        _spawnedFood.RemoveAll(food => food == null);

        if (_spawnedFood.Count < _maxSpawning)
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
        GameObject newFood = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

        _spawnedFood.Add(newFood);
    }
}