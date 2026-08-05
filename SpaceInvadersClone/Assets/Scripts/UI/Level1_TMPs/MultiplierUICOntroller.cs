using UnityEngine;
using TMPro;

public class MultiplierUICOntroller : MonoBehaviour
{
    private ScoreManager scoreManager;
    private TMP_Text Multiplier;

    void Start()
    {
        Multiplier = GetComponent<TMP_Text>();
        scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
    }

    
    void Update()
    {
        float multiplier = scoreManager.scoreMultiplier;
        Multiplier.text = $"Multiplier:{multiplier.ToString("F1")}";
    }
}
