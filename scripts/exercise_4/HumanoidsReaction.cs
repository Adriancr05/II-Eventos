using UnityEngine;

public class HumanoidsReaction : MonoBehaviour
{
    public Transform targetObject;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        CubeNotifier.OnCubeNear += Reaction;
    }

    void OnDestroy()
    {
        CubeNotifier.OnCubeNear -= Reaction;
    }

    void Reaction()
    {
        if (gameObject.CompareTag("Type1"))
        {
            transform.position = targetObject.position;
        }
        else if (gameObject.CompareTag("Type2"))
        {
            transform.LookAt(new Vector3(targetObject.position.x, transform.position.y, targetObject.position.z));
        }
    }
}
