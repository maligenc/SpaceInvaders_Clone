using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject Bullet;
    private float fireTime = -0.5f;
    [SerializeField] private float fireWindow = 0f;
    [SerializeField] AudioManager audioManager;

    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed && Time.time >fireTime + fireWindow)
        {
            audioManager.playSFX(audioManager.playerShoot);
            Shoot();
            fireTime = Time.time;
        }
    }

    void Shoot()
    {
        //ShootingLogic
        Instantiate(Bullet,FirePoint.position,FirePoint.rotation);
    }

}
