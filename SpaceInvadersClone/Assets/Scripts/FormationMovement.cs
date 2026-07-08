using UnityEngine;

public class FormationMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float speed = 10f;
    public Vector2 direction = Vector2.right;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D()
    {
        speed *=-1.0f;
    }

    void FixedUpdate()
    {
        Vector2 Movement = direction *speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position+Movement);
    }

}
