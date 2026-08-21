using TMPro;
using UnityEngine;

public class ScoreDisplayController : MonoBehaviour
{
    private ScoreManager scoreManager;
    private TMP_Text scoreText;
    private float score;

    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
        score = scoreManager.totalScore;
    }

    void Update()
    {
        scoreText.text = $"Score : {(int)score}";
    }
}
