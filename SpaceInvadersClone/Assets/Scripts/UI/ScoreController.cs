using UnityEngine;
using TMPro;


public class ScoreController : MonoBehaviour
{
    [SerializeField] private int pointMultiplier=0;
    private TMP_Text Score;
    public Transform formationTransfrom;
    private int initialEnemyCount=0;

    void Start()
    {
        Score = GetComponent<TMP_Text>();
        initialEnemyCount=formationTransfrom.childCount;
    }

    void Update()
    {
        int killedEnemyCount = initialEnemyCount-formationTransfrom.childCount;
        int score = killedEnemyCount*pointMultiplier;
        Score.text = $"Score:{score}";    
    }

}
