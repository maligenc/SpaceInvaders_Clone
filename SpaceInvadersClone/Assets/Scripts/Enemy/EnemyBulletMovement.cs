using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    private Rigidbody2D BulletBody;
    private float speed = -10f;
    void Start()
    {
        BulletBody = GetComponent<Rigidbody2D>();
        BulletBody.linearVelocityY = speed;
    }

    void OnTriggerEnter2D(Collider2D HitInfo)
    {
        Destroy(gameObject);
    }
}

