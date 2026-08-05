using UnityEngine;
using TMPro;

public class StreakCounterControllerUI : MonoBehaviour
{
    [SerializeField] public ScoreManager scoreManager;
    
    private TMP_Text Streak;

    void Start()
    {
        Streak = GetComponent<TMP_Text>();
        scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
    }

    void Update()
    {
        int streak = scoreManager.streak - 5;
        Streak.text = $"Streak:{streak}";
    }
}
