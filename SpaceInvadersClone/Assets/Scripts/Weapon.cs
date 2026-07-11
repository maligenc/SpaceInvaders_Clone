using UnityEngine;
using UnityEngine.InputSystem;


public class Weapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform FirePoint;
    public GameObject Bullet;
    private float fireTime = -0.5f;
     
    // Update is called once per frame
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
