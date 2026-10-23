using UnityEngine;
// Ejercicio 4
public class CubeNotifier : MonoBehaviour
{
    public delegate void CubeDelegate();
    public static event CubeDelegate OnCubeNear;
    public Transform cube;

    void Update()
    {
        if (Vector3.Distance(transform.position, cube.position) < 5f)
        {
            OnCubeNear();
        }
    }
}
