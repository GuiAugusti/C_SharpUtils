using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Script1 : MonoBehaviour
{
    [SerializeField] private UnityEvent coolUnityEvent;

    private void Start()
    {
        coolUnityEvent.Invoke();
    }

    public void DebugValue(int valueToPrint)
    {
        Debug.Log(valueToPrint);
    }
}
