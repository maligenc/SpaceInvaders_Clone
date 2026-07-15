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
}
