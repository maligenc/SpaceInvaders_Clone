using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private float killPoint = 10;
    [SerializeField] private float multiplierFactor = 0.3f;
    public float scoreMultiplier = 1.0f;
    public float totalScore = 0.0f;
    public int streak = 5; 


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
        scoreMultiplier = 1.0f;
    }
}
