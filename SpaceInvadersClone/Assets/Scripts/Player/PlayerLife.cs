using Unity.VisualScripting;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int HP=0;
    [SerializeField] private GameObject HitAnimation;
    [SerializeField] private GameObject DeathAnimation;
    [SerializeField] private AudioManager audioManager;
    private Rigidbody2D rb;
    public bool playerDead = false;
    private SpriteRenderer sr;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
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
        HP -=1;
        if (HP != 0)
        {
            Instantiate(HitAnimation,transform.position,transform.rotation);
        }
        
    }
}
