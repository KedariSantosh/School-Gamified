using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public ShootLaser sLaser;
    public GameObject door;
    public Renderer sensorColor;
    #region Events Subscription
    private void OnEnable()
    {
        EventManager.Instance.TriggeredTargetAction += OpenDoor;
        EventManager.Instance.MissedTrigger += CloseDoor;
    }
    private void OnDisable()
    {
        EventManager.Instance.TriggeredTargetAction -= OpenDoor;
        EventManager.Instance.MissedTrigger -= CloseDoor;
    }
    #endregion
    public void OpenDoor()
    {
        if (sLaser.hitName == door.name)
        {
            print("Opening Door");
            AnimationManager.instance.AnimatePlatformOpen(door,0,0,90);
            sensorColor.material.color = Color.green;
        }
    }
    public void CloseDoor()
    {
        print("closing Door");
        sensorColor.material.color = Color.red;
        AnimationManager.instance.AnimatePlatformClose(door,0,0,0);
    }
}