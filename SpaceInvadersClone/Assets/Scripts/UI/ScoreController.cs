using UnityEngine;
using TMPro;


public class ScoreController : MonoBehaviour
{
    [SerializeField]public ScoreManager scoreManager;
    [SerializeField] private int killPoint=0;
    private TMP_Text Score;
    public Transform formationTransfrom;



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
