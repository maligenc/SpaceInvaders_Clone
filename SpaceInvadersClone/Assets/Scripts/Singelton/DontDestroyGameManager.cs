using UnityEngine;

public class DontDestroyGameManager : MonoBehaviour
{
    private static DontDestroyGameManager GameManager;
    void Awake()
    {
        if (GameManager != null && GameManager !=this)
        {
            Destroy(gameObject);
        }
        else if(GameManager == null)
        {
            GameManager = this;
        }
        DontDestroyOnLoad(gameObject);

    }
}
