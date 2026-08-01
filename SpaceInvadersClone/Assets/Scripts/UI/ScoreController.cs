using UnityEngine;
using TMPro;


public class ScoreController : MonoBehaviour
{
    [SerializeField]public ScoreManager scoreManager;
    [SerializeField] private int killPoint=0;
    private TMP_Text Score;
    public Transform formationTransfrom;
    private int initialEnemyCount=0;
    public float scoreMultiplier = 1.0f;


    void Start()
    {
        Score = GetComponent<TMP_Text>();
        initialEnemyCount=formationTransfrom.childCount;
    }

    void Update()
    {
        // int killedEnemyCount = initialEnemyCount-formationTransfrom.childCount;
        // int score = killedEnemyCount*killPoint;
        float totalScore = scoreManager.totalScore;
        Score.text = $"Score:{totalScore}";    
    }

}
