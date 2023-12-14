using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : IDContainerBehaviour
{
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent; 

    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if (tempObj == null)
        yield break;

        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            UnityEditor.EditorApplication.isPlaying = false;
            /*yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
            */
        }
    }

}
