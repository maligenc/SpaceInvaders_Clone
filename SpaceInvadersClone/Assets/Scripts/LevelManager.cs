using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private PlayerLife playerLife;
    [SerializeField] private FormationMovement formationMovement;
    [SerializeField] private string destinationRoom;
    public GameObject playerShip;

    // Update is called once per frame
    void Update()
    {
        if (playerLife.HP <= 0)
        {
            Destroy(playerShip);
            SceneManager.LoadScene("You_Lose");
            Debug.Log("Gemi öldü ekran değişmeliydi");
        }
        else if (formationMovement.isAllEnemyDead)
        {
            SceneManager.LoadScene(destinationRoom);
        }
    }
}
