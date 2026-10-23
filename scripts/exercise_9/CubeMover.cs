using UnityEngine;
// Ejercicio 3
public class CubeMover : MonoBehaviour
{
    public float moveSpeed = 3f;
    private Rigidbody rb;
    private Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
    }
}
