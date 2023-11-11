using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VPlayerController : MonoBehaviour
{

    public float speed = 2.5f;

    public float horizontalInput;


        void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); 

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
}
