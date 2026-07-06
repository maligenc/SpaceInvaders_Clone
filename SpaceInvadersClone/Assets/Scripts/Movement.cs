using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D BulletBody;
    private float speed = 20f;
    void Start()
    {
        BulletBody = GetComponent<Rigidbody2D>();
        BulletBody.linearVelocityY = speed;
    }

    void OnTriggerEnter2D(Collider2D HitInfo)
    {
        Debug.Log(HitInfo.name);
        Destroy(gameObject);
    }
}
