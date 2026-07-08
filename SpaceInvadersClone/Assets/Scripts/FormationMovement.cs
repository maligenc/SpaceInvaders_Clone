using UnityEngine;

public class FormationMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float speed = 10f;

    [SerializeField]
    private Transform FormationCenter;

    private Vector2 direction = Vector2.right;

    public Vector2 farRightChild = Vector2.zero;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        foreach (Transform child in transform)
        {
            if (speed > 0)
            {
                if(child.position.x > farRightChild.x)
                {
                    farRightChild.x=child.position.x;
                }
            }
            else
            {
                if(child.position.x < farRightChild.x)
                {
                    farRightChild.x=child.position.x;
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (farRightChild.x < -7 ||farRightChild.x>7)
        {
            speed *=-1;
        }
        Vector2 Movement = direction *speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position+Movement);

    }

}
