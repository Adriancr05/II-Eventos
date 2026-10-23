using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform targetObject;
    public float moveSpeed = 3f;
    private Rigidbody rb;
    private bool canMove = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        CylinderCollision.OnCubeHit += EnableMovement;
    }

    private void EnableMovement()
    {
        canMove = true;
    }

    private void FixedUpdate()
    {
        if (canMove && targetObject != null)
        {
            transform.LookAt(targetObject);
            rb.MovePosition(transform.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
