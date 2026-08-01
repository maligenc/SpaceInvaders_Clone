using UnityEngine;

public class Box_death : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    public Transform AnimationCenter;
    public GameObject Corpse;
    private AudioManager audioManager;
    void Start()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
    }
    void OnTriggerEnter2D(Collider2D HitInfo)
    {
        audioManager.playSFX(audioManager.enemyHit);
        Debug.Log(HitInfo.name);
        scoreManager.addScore();
        scoreManager.addMultiplier();
        Destroy(gameObject);
        Instantiate(Corpse,AnimationCenter.position,AnimationCenter.rotation);
    }

}
