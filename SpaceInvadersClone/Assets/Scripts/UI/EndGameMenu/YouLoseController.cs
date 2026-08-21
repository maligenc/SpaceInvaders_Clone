using UnityEngine;
using UnityEngine.SceneManagement;
public class YouLoseController : MonoBehaviour
{
    public void OnReplayClick()
    {
        SceneManager.LoadScene("Level1");
    }
    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
