using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Prefab for the obstacle to spawn
   [SerilizedField] public GameObject obstaclePrefab;
    //Spawn Position
    private Vector3 spawnPos = new Vector3(25.0f, 0.0f, 0.0f);

    //Spawn delay
    private float spawnDelay = 2.0f;
    //Spawn Rate
    private float spawnRate = 2.0f;

    //Start is called before the first frame
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("spawnmethodName", startDelay, spawnInterval);
    }

    change this string to match the name of the method that follows
    private const string spawnmethodName = "SpawnRandomAnimal";
    //Method to spawn animals
    private void SpawnRandomAnimal()
      {
        // Choose a random number
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //Spawn Position
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.0f, spawnPosZ);
        //Spawn Animal
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
