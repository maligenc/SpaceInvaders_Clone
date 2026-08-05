using UnityEngine;
using TMPro;

public class StreakBonusController : MonoBehaviour
{
    private ScoreManager scoreManager;
    private TMP_Text bonus;

    void Start()
    {
        bonus = GetComponent<TMP_Text>();
        scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
    }

    
    void Update()
    {
        float currentBonus = (int)scoreManager.streak/5 * scoreManager.multiplierFactor;
        bonus.text = $"Bonus:{currentBonus}";
    }
}
