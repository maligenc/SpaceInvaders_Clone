using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class StreakMultiplierController : MonoBehaviour
{
    public ScoreManager scoreManager;
    [SerializeField] private int maxMod = 5;
    [SerializeField] private Sprite hit;
    [SerializeField] private Sprite wait;
    [SerializeField] private Image[] dots;

    void Start()
    {
        scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
    }
    void Update()
    {
        int streak = scoreManager.streak % 5;
        for (int i = 0; i < dots.Length; i++)
        {
            if(i < streak)
            {
                dots[i].sprite = hit;
            }
            else
            {
                dots[i].sprite = wait;
            }
            if (i < maxMod)
            {
                dots[i].enabled = true;
            }
            else
            {
                dots[i].enabled = false;
            }
        }
    }
}
