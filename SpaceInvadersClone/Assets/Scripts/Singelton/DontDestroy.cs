using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    private static DontDestroy conveyorBelt;
    void Awake()
    {
        if (conveyorBelt != null && conveyorBelt !=this)
        {
            Destroy(gameObject);
        }
        else if(conveyorBelt == null)
        {
            conveyorBelt = this;
        }
        DontDestroyOnLoad(gameObject);

    }
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "You_Lose")
        {
            Destroy(gameObject);
        } 
    }
}
