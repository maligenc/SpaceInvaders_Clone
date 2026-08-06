using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinController : MonoBehaviour
{
    public void WinOnReplayClick()
    {
        SceneManager.LoadScene("Level1");
    }
}
