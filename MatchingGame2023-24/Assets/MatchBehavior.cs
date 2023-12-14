using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;

    private void OnTiggerEnter(Collider other)
    {
        Debug.Log(idObj);
        Debug.Log(other.GetComponent<IDContainerBehaviour>().idObj);
    }  
}
