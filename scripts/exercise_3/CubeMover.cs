using UnityEngine;
// Ejercicio 3
public class CubeMover : MonoBehaviour
{
    public float moveSpeed = 3f;

    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * moveSpeed * Time.deltaTime);
    }
}
