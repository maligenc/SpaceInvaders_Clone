using Unity.VisualScripting;
using UnityEngine;

public class GetInScene : MonoBehaviour
{
    [SerializeField] private float initalSpeed = -2f;
    [SerializeField] private Rigidbody2D enemySpaceShip;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float duration = 0f;


    void Start()
    {
        enemySpaceShip = GetComponent<Rigidbody2D>();
        enemySpaceShip.linearVelocityY= initalSpeed;

    }


    void Update()
    {
        float currentTime =0f;
        enemySpaceShip.linearVelocityY = enemySpaceShip.linearVelocityY * curve.Evaluate(currentTime/duration);
    }

}
