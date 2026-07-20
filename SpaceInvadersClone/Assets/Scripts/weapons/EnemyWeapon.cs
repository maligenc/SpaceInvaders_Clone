using Unity.VisualScripting;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    [SerializeField] private Transform FirePoint;
    [SerializeField] private GameObject EnemyBullet;
    [SerializeField] private float MinShootingWindow=0.0f;
    [SerializeField] private float MaxShootingWindow=0.0f;
    [SerializeField] private AudioManager audioManager;

    private float ShootCalculateWindow=0;
    private float TryShootTime=1;

    void Awake()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }
    void Start()
    {
        ShootCalculateWindow = Random.Range(MinShootingWindow,MaxShootingWindow);
        TryShootTime = Time.time+ShootCalculateWindow;
    }
    void Update()
    {
        if (Time.time  >= TryShootTime)
        {
            float shoot = Random.Range(0f,1f);
            if(shoot <= 1f*(1f/transform.parent.childCount))
            {
                audioManager.playSFX(audioManager.enemyShoot);
                Shoot();
            }
            ShootCalculateWindow = Random.Range(MinShootingWindow,MaxShootingWindow);
            TryShootTime += ShootCalculateWindow;
            
        }
    }
    void Shoot()
    {
        Instantiate(EnemyBullet,FirePoint.position,FirePoint.rotation);
    }
}
