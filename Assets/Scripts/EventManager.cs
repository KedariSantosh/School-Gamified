using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance { get; private set; }
    private void Awake() { Instance = this; }

    public Action TriggeredTargetAction;
    public Action MissedTrigger;
    public void TargetHit() 
    {
        TriggeredTargetAction.Invoke();
    }

    public void MissTarget()
    {
        MissedTrigger.Invoke();
    }   
}