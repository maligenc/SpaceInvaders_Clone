using Unity.VisualScripting;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int HP=0;
    [SerializeField] private GameObject HitAnimation;
    [SerializeField] private GameObject DeathAnimation;
    [SerializeField] private AudioManager audioManager;
    [SerializeField] private CameraShake cameraShake;
    private ScoreManager scoreManager;
    private Rigidbody2D rb;
    public bool playerDead = false;
    private SpriteRenderer sr;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
    }

    void Update()
    {
        if (HP<=0)
        {
            playerDead = true;
            Instantiate(DeathAnimation,transform.position,transform.rotation);
        }

    }
    void OnTriggerEnter2D()
    {
        audioManager.playSFX(audioManager.playerHit);
        cameraShake.ShakeCamera();
        HP -=1;
        scoreManager.resetMultiplier();
        if (HP != 0)
        {
            Instantiate(HitAnimation,transform.position,transform.rotation);
        }
        
    }
}
