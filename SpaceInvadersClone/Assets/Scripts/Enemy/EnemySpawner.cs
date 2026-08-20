
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private float waveSpeedBonus=0;
    private float waveAgressionBonus = 0;
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
    [SerializeField] private EnemyWeapon enemyWeapon;

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
        if (columnSize <= 12)
        {
            if (wavecount % 3 == 0)
            {
                columnSize += 1;
                formationMovement.enemycount = columnSize*rowSize;
            }
        }
        if(wavecount % 2 == 0)
        {
            waveSpeedBonus += 0.2f;
        }

        if(wavecount % 2 == 0)
        {
            waveAgressionBonus += 0.2f;
        }

        for(int row =0 ; row<rowSize ; row++)
        {
            for(int col =0 ; col<columnSize ; col++)
            {
                Vector3 spawn = SpawnerPoint.position;
                spawn.y += row*rowMultiplier;
                spawn.x += col*columnMultiplier;
                GameObject spawned = Instantiate(Enemy,spawn,SpawnerPoint.rotation,FormationCenter);
                spawned.GetComponent<EnemyWeapon>().MaxShootingWindow -=waveAgressionBonus;
            }
        }


        formationMovement.speed = 1f + waveSpeedBonus;
        formationMovement.isAllEnemyDead = false;
        formationMovement.checkAgain = true;
        waveManager.stopInvokeNextWave = false;
    }

}
