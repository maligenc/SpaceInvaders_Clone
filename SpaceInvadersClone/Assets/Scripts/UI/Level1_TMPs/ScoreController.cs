using UnityEngine;
using TMPro;


public class ScoreController : MonoBehaviour
{
    [SerializeField]public ScoreManager scoreManager;
    private TMP_Text Score;

    void Start()
    {
        Score = GetComponent<TMP_Text>();
        scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
    }

    void Update()
    {
        float totalScore = scoreManager.totalScore;
        Score.text = $"Score:{totalScore}";    
    }

}
