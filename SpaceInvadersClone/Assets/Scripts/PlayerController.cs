using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 100.0f; 
    private Rigidbody2D rb; 
    private Vector2 moveInput = Vector2.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component not found on the player object.");
        }
    }

    void Update()
    {
        //Left movement
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) moveInput.x=-1f;
        //Right Movement
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) moveInput.x=1f;
        //Stop movement
        if (!Keyboard.current.dKey.isPressed && !Keyboard.current.rightArrowKey.isPressed && !Keyboard.current.leftArrowKey.isPressed && !Keyboard.current.aKey.isPressed) moveInput.x=0f;
    }

    void FixedUpdate()
    {
        Vector2 Movement = moveInput * speed * Time.fixedDeltaTime; 
        rb.MovePosition(rb.position + Movement);
    }
}
