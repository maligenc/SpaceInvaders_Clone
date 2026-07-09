using UnityEngine;

public class FormationMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float speed = 10f;
    private Vector2 direction = Vector2.right;

    public Vector2 farRightChild = Vector2.zero;

    [SerializeField]
    private float SlideDown = 0.1f;
   

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
        float ChildCount = transform.childCount * 0.1f;
        float RealSpeed = speed-ChildCount;
        Vector2 slide = Vector2.zero;
        if (farRightChild.x < -7 ||farRightChild.x>7)
        {
            speed *=-1;
            slide = Vector2.down * SlideDown;
        }
        Vector2 Movement = direction *RealSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + Movement + slide);

    }

}
