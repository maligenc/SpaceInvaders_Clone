using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private PlayerLife playerLife;
    [SerializeField] private FormationMovement formationMovement;
    public GameObject playerShip;

    // Update is called once per frame
    void Update()
    {
        if (playerLife.HP <= 0)
        {
            Destroy(playerShip);
            SceneManager.LoadScene("You_Lose");
        }
        else if (formationMovement.isAllEnemyDead)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
