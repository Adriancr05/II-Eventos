using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI rewardText;
    public TextMeshProUGUI winningText;
    private int score = 0;
    private int rewards = 0;
    private const int rewardScore = 100;
    private const int winingScore = 500;

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

        rewards = score / rewardScore;
        if (rewards > 0)
        {
            ShowReward();
        }

        if (score == winingScore)
        {
            ShowWinning();
        }
    }
    void UpdateText()
    {
        scoreText.text = "Score: " + score;
    }

    void ShowReward()
    {
        rewardText.text = "Secret rewards: " + rewards;
    }

    void ShowWinning()
    {
        winningText.text = "YOU WON!";
    }
}
