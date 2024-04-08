using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle : MonoBehaviour
{
    public static Shuffle Instance;
    public GameObject[] objectsToShuffle; 
    public float forceMagnitude = 5f;
    private void Awake()
    {
        Instance = this;
    }
    void OnMouseDown()
    {
        Debug.Log("shuffle click");
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
