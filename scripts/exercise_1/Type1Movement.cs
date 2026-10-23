using UnityEngine;

public class Type1Movement : MonoBehaviour
{
    public Transform targetObject;
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
        if (canMove && targetObject != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetObject.position, moveSpeed * Time.deltaTime);
        }
    }
}
