using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class FormationMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public int enemycount;
    private Vector2 direction = Vector2.right;
    private Vector2 leadingEdgeX = Vector2.zero;
    public bool isAllEnemyDead = false;
    public bool checkAgain = true;
    private WaveManager waveManager;
    public float speed = 10f;

    [SerializeField] private PlayerController playerController;
    [SerializeField] private PlayerLife playerLife;
    [SerializeField] private float SlideDown = 0.2f;
    [SerializeField] private float EnemyDeathMultiplier = 0.03125f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        enemycount = transform.childCount;
        waveManager = GameObject.Find("GameManager").GetComponent<WaveManager>();
    }
    void OnEnable()
    {
        waveManager.nextWave += ResetFormationPositionAndStop;
    }
    void OnDisable()
    {
        waveManager.nextWave -=ResetFormationPositionAndStop;
    }

    void Update()
    {
        leadingEdgeX.y = float.MaxValue;
        if (direction == Vector2.right)
        {
            leadingEdgeX.x=float.MinValue;
        }
        else
        {
            leadingEdgeX.x=float.MaxValue;
        }
        foreach(Transform child in transform)
        {
            if(child.position.y < leadingEdgeX.y)
            {
                //when leadingEdgeX.y == -3.5 trigger event lost 
                leadingEdgeX.y = child.position.y;
            }
        }
        foreach (Transform child in transform)
        {

            if (direction == Vector2.right)
            {
                if(child.position.x > leadingEdgeX.x)
                {
                    leadingEdgeX.x=child.position.x;
                }
            }
            else
            {
                if(child.position.x < leadingEdgeX.x)
                {
                    leadingEdgeX.x=child.position.x;
                }
            }
        }
        if(!isAllEnemyDead && transform.childCount == 0 && checkAgain)
        {
            isAllEnemyDead = true;
        }
    }

    void FixedUpdate()
    {
        float EnemyDeath = (enemycount - transform.childCount) * EnemyDeathMultiplier;
        float RealSpeed = speed+EnemyDeath;
        Vector2 slide = Vector2.zero;


        if (leadingEdgeX.x>7)
        {
            direction = Vector2.left;
            slide = Vector2.down * SlideDown;
        }
        else if(leadingEdgeX.x < -7)
        {
            direction = Vector2.right;
            slide = Vector2.down * SlideDown;
        }
        Vector2 Movement = direction *RealSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + Movement + slide);

        if (leadingEdgeX.y <= playerController.gameObject.transform.position.y+(playerController.gameObject.transform.localScale.y/2))
        {
            playerLife.HP = 0;
        }

    }
    
    void ResetFormationPositionAndStop(float wave)
    {
        checkAgain = false;
        speed = 0f;
        transform.position = new Vector3(0f,2.15f,0);
    }

}
