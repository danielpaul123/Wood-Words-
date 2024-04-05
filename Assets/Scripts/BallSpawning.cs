using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawning : MonoBehaviour
{
    public GameObject[] objectsToSpawn; 
    void Start()
    {
        foreach (GameObject item in objectsToSpawn)
        {
            
            Instantiate(item, transform.position, transform.rotation);
        }
    }

}

