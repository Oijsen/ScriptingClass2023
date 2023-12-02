using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityQuitEvent : MonoBehaviour
{
    public UnityEvent quitEvent;

    private void Application.Quit()
    {
        quitEvent.Invoke();
    }
}
