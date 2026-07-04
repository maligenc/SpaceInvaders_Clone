using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 100.0f; // Speed of the player movement
    
    private Rigidbody2D rb; // Reference to the player's Rigidbody2D component
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to the player
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component not found on the player object.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = Vector2.zero; // Initialize movement input to zero

        //Left movement
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) moveInput.x=-1f;
        //Right Movement
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) moveInput.x=1f;

        Vector2 Movement = moveInput * speed * Time.deltaTime; 

        rb.MovePosition(rb.position + Movement);
    }
}
