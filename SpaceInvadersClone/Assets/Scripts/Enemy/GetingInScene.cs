using Unity.VisualScripting;
using UnityEngine;

public class GetingInScene : MonoBehaviour
{
    [SerializeField] private float initalSpeed = -2f;
    [SerializeField] private Rigidbody2D enemySpaceShip;


    void Start()
    {
        enemySpaceShip = GetComponent<Rigidbody2D>();
        enemySpaceShip.linearVelocityY= initalSpeed;
    }


    void Update()
    {
        enemySpaceShip.linearVelocityY += 4f;
    }
}
