
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform SpawnerPoint;
    [SerializeField] private GameObject Enemy;
    [SerializeField] private int columnSize;
    [SerializeField] private int rowSize;
    [SerializeField] private float  columnMultiplier = 0.5f;
    [SerializeField] private float rowMultiplier = 0.5f;
    [SerializeField] private Transform FormationCenter;
    [SerializeField] private WaveDisplay waveDisplay;
    [SerializeField] private FormationMovement formationMovement;
    [SerializeField] private WaveManager waveManager;

    void Awake()
    {
        for(int row =0 ; row<rowSize ; row++)
        {
            for(int col =0 ; col<columnSize ; col++)
            {
                Vector3 spawn = SpawnerPoint.position;
                spawn.y += row*rowMultiplier;
                spawn.x += col*columnMultiplier;
                Instantiate(Enemy,spawn,SpawnerPoint.rotation,FormationCenter);
            }
        }
    }

    void OnEnable()
    {
        waveDisplay.spawnNextWave += SpawnEnemies;
    }
    void OnDisable()
    {
        waveDisplay.spawnNextWave -= SpawnEnemies;
    }
    void SpawnEnemies(float wavecount)
    {
        for(int row =0 ; row<rowSize ; row++)
        {
            for(int col =0 ; col<columnSize ; col++)
            {
                Vector3 spawn = SpawnerPoint.position;
                spawn.y += row*rowMultiplier;
                spawn.x += col*columnMultiplier;
                Instantiate(Enemy,spawn,SpawnerPoint.rotation,FormationCenter);
            }
        }
        formationMovement.speed = 1f;
        formationMovement.isAllEnemyDead = false;
        formationMovement.checkAgain = true;
        waveManager.stopInvokeNextWave = false;
    }

}
