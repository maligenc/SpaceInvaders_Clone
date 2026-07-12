using Unity.VisualScripting;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField]
    private int HP=0;
    [SerializeField]
    private GameObject HitAnimation;
    [SerializeField]
    private GameObject DeathAnimation;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HP==0)
        {
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
