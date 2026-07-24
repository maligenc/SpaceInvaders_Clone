using JetBrains.Annotations;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Ground;
    [SerializeField] private float speed = -0.3f;
    private Vector2 slideGround;

    void Start()
    {
        Ground.linearVelocityY = speed;
        
    }

    void Update()
    {
        if(transform.position.y <= -11)
        {
            slideGround.y = 21.9f;
            Ground.MovePosition(Ground.position + slideGround);
        }
    }
}
