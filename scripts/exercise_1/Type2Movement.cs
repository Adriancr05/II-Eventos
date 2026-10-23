using UnityEngine;

public class Type2Movement : MonoBehaviour
{
    public Transform cylinder;
    public float moveSpeed = 3f;
    private bool canMove = false;

    private void Start()
    {
        CylinderCollision.OnCubeHit += EnableMovement;
    }

    private void EnableMovement()
    {
        canMove = true;
    }

    private void Update()
    {
        if (canMove && cylinder != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, cylinder.position, moveSpeed * Time.deltaTime);
        }
    }
}
