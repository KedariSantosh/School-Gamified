using UnityEngine;
public class ShootLaser : MonoBehaviour
{
    public Material material;
    public LaserBeam beam;
    public string hitName;
    void Update()  
    {
        if (beam != null)
            Destroy(beam.laserObj);
        beam = new LaserBeam(gameObject.transform.position, gameObject.transform.forward, material, transform);

        if (beam.hitObject != null)
        {
            hitName=beam.hitObject.name;
        }
        if (beam.hitObject == null)
            EventManager.Instance.MissTarget();
    }
}