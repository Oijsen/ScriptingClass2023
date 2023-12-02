using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{

    public GameObject laser; 

    public Transform gun;

    // Start is called before the first frame update
    void Start()
    {
        //gun = new Vector3(0f, 1.1f, 0f);
        InvokeRepeating("Fire", 1.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fire() 
    {
        Instantiate(laser, gun.position, Quaternion.Euler(90, 0, 0));

    }
}
