using UnityEngine;

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
}
