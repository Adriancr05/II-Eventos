using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Start()
    {
        UpdateText();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Type1"))
        {
            score += 5;
            UpdateText();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Type2"))
        {
            score += 10;
            UpdateText();
            Destroy(other.gameObject);
        }
    }
    void UpdateText()
    {
        scoreText.text = "Score: " + score;
    }
}
