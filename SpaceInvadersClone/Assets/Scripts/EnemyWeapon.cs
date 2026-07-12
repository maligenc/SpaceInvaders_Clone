using Unity.VisualScripting;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    [SerializeField]
    private Transform FirePoint;

    [SerializeField]
    private GameObject EnemyBullet;

    private int ShootCalculateWindow=0;
    [SerializeField]
    private int MinShootingWindow=0;
    [SerializeField]
    private int MaxShootingWindow=0;
    private float TryShootTime;

    void Start()
    {
        ShootCalculateWindow = Random.Range(MinShootingWindow,MaxShootingWindow);
        TryShootTime = Time.time+ShootCalculateWindow;
    }
    void Update()
    {
        if (Time.time  >= TryShootTime)
        {
            int shoot = Random.Range(0,10);
            if(shoot <= 3)
            {
                Shoot();
            }
            TryShootTime += ShootCalculateWindow;
        }
    }
    void Shoot()
    {
        Instantiate(EnemyBullet,FirePoint.position,FirePoint.rotation);
    }
}
