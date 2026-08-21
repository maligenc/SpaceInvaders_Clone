using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private PlayerLife playerLife;
    [SerializeField] private FormationMovement formationMovement;
    public GameObject playerShip;

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnLoadedScene;       
    }
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLoadedScene;
    }

    void OnLoadedScene(Scene scene,LoadSceneMode loadSceneMode)
    {
        if(scene.name == "Level1")
        {
            playerLife = GameObject.Find("Player_SpaceShip").GetComponent<PlayerLife>();
            playerShip = GameObject.Find("Player_SpaceShip");
            formationMovement = GameObject.Find("FormationCenter").GetComponent<FormationMovement>();

        }
    }
    void Update()
    {
        if (playerLife.HP <= 0)
        {
            Destroy(playerShip);
            SceneManager.LoadScene("You_Lose");
        }
    }
}
