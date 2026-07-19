using UnityEngine;
using UnityEngine.SceneManagement;
public class YouLoseController : MonoBehaviour
{
    public void OnReplayClick()
    {
        SceneManager.LoadScene("Level1");
    }
}
