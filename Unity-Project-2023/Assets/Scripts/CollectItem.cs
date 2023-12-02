using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{

public int Points = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Chest"))
        {
            Debug.Log("Chest Received!");
            Points = Points + 5; 
            Debug.Log("You have " + Points + " points!");
            Destroy(other.gameObject);
        }

    }
}
