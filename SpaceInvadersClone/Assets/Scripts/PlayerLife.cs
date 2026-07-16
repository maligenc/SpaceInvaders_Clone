using Unity.VisualScripting;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int HP=0;
    [SerializeField] private GameObject HitAnimation;
    [SerializeField] private GameObject DeathAnimation;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (HP==0)
        {
            //sr.enabled=false;
            Destroy(gameObject);
            Instantiate(DeathAnimation,transform.position,transform.rotation);
        }

    }
    void OnTriggerEnter2D()
    {
        HP -=1;
        if (HP != 0)
        {
            Instantiate(HitAnimation,transform.position,transform.rotation);
        }
        
    }
}
