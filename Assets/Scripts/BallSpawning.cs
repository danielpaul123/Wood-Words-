using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawning : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public Transform[] spawnPoints;

    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
      /*  if (objectsToSpawn.Length == 0 || spawnPoints.Length == 0)
        {
            Debug.LogWarning("No objects to spawn or no spawn points specified.");
            return;
        }*/

        for (int i = 0; i < objectsToSpawn.Length; i++)
        {
            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(objectsToSpawn[i], spawnPoint.position, spawnPoint.rotation);
        }
    }
}

