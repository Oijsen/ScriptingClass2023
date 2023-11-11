using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFabMovement : MonoBehaviour
{
    public float speed = 3.2f;

    private float topBoundary = 7;

    private float bottomBoundary = -5; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.z < bottomBoundary){

            Destroy(gameObject);
        }

        if (transform.position.z > topBoundary){

            Destroy(gameObject);
        }
    }
}
