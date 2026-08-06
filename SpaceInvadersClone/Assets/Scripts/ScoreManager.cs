using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private float killPoint = 10;
    [SerializeField] public float multiplierFactor = 0.3f;
    public float scoreMultiplier = 1.0f;
    public float totalScore = 0.0f;
    public int streak = 5;

    void OnEnable()
    {
        SceneManager.sceneLoaded += ResetScore;
    }
    void OnDisable()
    {
        SceneManager.sceneLoaded -= ResetScore;
    }

    void ResetScore(Scene scene,LoadSceneMode loadSceneMode)
    {
        if (scene.name == "Level1")
        {
            streak = 5;
            totalScore = 0.0f;
            scoreMultiplier = 1.0f;
        }
    }

    public void addUpPoint()
    {
        totalScore += killPoint*scoreMultiplier;
        Debug.Log(scoreMultiplier);
        Debug.Log(totalScore);
    }

    public void addMultiplier()
    {
        float streakMod = streak / 5;
        scoreMultiplier += (int)streakMod * multiplierFactor;
        streak+=1;
    }
    public void addScore()
    {
        totalScore += scoreMultiplier * killPoint;
    }
    public void resetMultiplier()
    {
        streak = 5;
        scoreMultiplier = 1.0f;
    }
}
