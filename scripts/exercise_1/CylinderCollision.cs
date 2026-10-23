using UnityEngine;

public class CylinderCollision : MonoBehaviour
{
    public delegate void CubeHitDelegate();
    public static event CubeHitDelegate OnCubeHit;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            if (OnCubeHit != null)
            {
                OnCubeHit();
            }
        }
    }
}
