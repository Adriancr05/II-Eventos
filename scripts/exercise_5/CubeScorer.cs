using UnityEngine;

public class CubeScorer : MonoBehaviour
{
    private int score = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Type1"))
        {
            score += 5;
            Debug.Log("Type 1 shield collected. Current score: " + score);
            Destroy(other.gameObject);
        }

        else if (other.CompareTag("Type2"))
        {
            score += 10;
            Debug.Log("Type 2 shield collected. Current score: " + score);
            Destroy(other.gameObject);
        }
    }
}
