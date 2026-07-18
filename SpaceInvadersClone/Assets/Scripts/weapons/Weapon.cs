using UnityEngine;
using UnityEngine.InputSystem;


public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject Bullet;
    private float fireTime = -0.5f;
     
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed && Time.time >fireTime + 0.5f)
        {
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
