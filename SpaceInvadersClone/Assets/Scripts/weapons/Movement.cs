using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D BulletBody;
    private float speed = 10f;
    private ScoreManager scoreManager;
    void Start()
    {
        BulletBody = GetComponent<Rigidbody2D>();
        BulletBody.linearVelocityY = speed;
        scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
    }
    void Update()
    {
        if(gameObject.transform.position.y >= 5.5f)
        {
            scoreManager.resetMultiplier();
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D HitInfo)
    {
        Destroy(gameObject);
    }
}
