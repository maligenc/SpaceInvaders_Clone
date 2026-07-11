using JetBrains.Annotations;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private Transform SpawnerPoint;
    [SerializeField]
    private GameObject Enemy;
    [SerializeField]
    private int columnSize;
    [SerializeField]
    private int rowSize;
    
    [SerializeField]
    private Transform FormationCenter;
    void Start()
    {
        for(int row =0 ; row<rowSize ; row++)
        {
            for(int col =0 ; col<columnSize ; col++)
            {
                Vector3 spawn = SpawnerPoint.position;
                spawn.y += row;
                spawn.x += col;
                Instantiate(Enemy,spawn,SpawnerPoint.rotation,FormationCenter);
            }
        }
    }
}
