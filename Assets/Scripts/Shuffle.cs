using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle : MonoBehaviour
{
    public GameObject[] objectsToShuffle; 
    public float forceMagnitude = 5f; 

    void OnMouseDown()
    {
        
        foreach (GameObject obj in objectsToShuffle)
        {
            
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null)
            {
                
                Vector3 randomDirection = Random.insideUnitSphere.normalized;
                rb.AddForce(randomDirection * forceMagnitude, ForceMode.Impulse);
            }
        }
    }

}
