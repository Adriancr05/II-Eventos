using UnityEngine;

public class ShieldColor : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Type1") || collision.gameObject.CompareTag("Type2"))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
