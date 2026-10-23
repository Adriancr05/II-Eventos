using UnityEngine;
// Ejercicio 3
public class HumanoidMovement : MonoBehaviour
{
    // Asignar en el Inspector el escudo que corresponda a este humanoide
    public Transform shield; 
    public float moveSpeed = 3f;
    private bool canMove = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.sleepThreshold = 0f;
        CubeManager.OnHitType1 += ReactType1;
        CubeManager.OnHitType2 += ReactType2;
    }

    void OnDestroy()
    {
        CubeManager.OnHitType1 -= ReactType1;
        CubeManager.OnHitType2 -= ReactType2;
    }

    void ReactType1()
    {
        if (gameObject.CompareTag("Type2")) canMove = true;
    }

    void ReactType2()
    {
        if (gameObject.CompareTag("Type1")) canMove = true;
    }

    void FixedUpdate()
    {
        if (canMove && shield != null)
        {
            Vector3 direction = new Vector3(shield.position.x, transform.position.y, shield.position.z);
            transform.LookAt(direction);
            rb.MovePosition(transform.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
