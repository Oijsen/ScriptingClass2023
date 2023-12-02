using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


//[RequireComponent(typeof(Collider))]
public class CollisionEventBehavior : MonoBehaviour
{
    public UnityEvent CollisionEnterEvent;

    private Collider colliderObj;

    private void Start()
    {
        colliderObj = GetComponent<Collider>();
    
    }

    private void OnCollisionEnter(Collider other)
    {
        CollisionEnterEvent.Invoke();
    }
}
