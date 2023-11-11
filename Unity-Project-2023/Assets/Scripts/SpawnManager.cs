using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject treasureChest;

    public GameObject enemyWeak; 

    public Vector3 spawnLocation; 

    void Start()
    {
      InvokeRepeating("Spawn", 2.0f, 3.0f);  
      InvokeRepeating("Spawn2", 5.0f, 8.0f);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Spawn()
    {
        spawnLocation = new Vector3(Random.Range(-3.7f, 3.7f), 1.1f, 7f);
        Instantiate(enemyWeak, spawnLocation, Quaternion.Euler(0, 180, 0));
    }

    void Spawn2()
    {
        spawnLocation = new Vector3(Random.Range(-3.7f, 3.7f), 1.1f, 7f);
        Instantiate(treasureChest, spawnLocation, Quaternion.Euler(0, 180, 0));
    }
   
}
