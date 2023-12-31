using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPreFabMovement : MonoBehaviour
{
    public float speed = 3.2f;

    private float topBoundary = 7;

    private float bottomBoundary = -5; 

    public int Points = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.z < bottomBoundary)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        
        

        if (transform.position.z > topBoundary)
        {

            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("Enemy Destroyed!");
            Points = Points + 5; 
            Debug.Log("You have " + Points + " points!");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        

    }
}