using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance { get; private set; }
    private void Awake() { Instance = this; }

    public Action getName;

    private void Start()
    {
        getName += SetName;
    }
    public void GetName()
    {
        getName.Invoke();
    }

    public void SetName()
    {
        print("hello what??");
    }
}