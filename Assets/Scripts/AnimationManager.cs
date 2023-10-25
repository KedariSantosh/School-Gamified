using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public static AnimationManager instance;
    private void Awake() { instance = this; }
    public void AnimatePlatformOpen(GameObject platform, float x, float y, float z)
    {
        platform.transform.rotation = Quaternion.Lerp(platform.transform.rotation, Quaternion.Euler(x, y, z), Time.deltaTime * 2f);
    }
    public void AnimatePlatformClose(GameObject platform, float x, float y, float z)
    {
        platform.transform.rotation = Quaternion.Lerp(platform.transform.rotation, Quaternion.Euler(x, y, z), Time.deltaTime * 2f);
    }
}