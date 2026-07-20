using UnityEngine;

public class Box_death : MonoBehaviour
{
    public Transform AnimationCenter;
    public GameObject Corpse;
    private AudioManager audioManager;
    void Awake()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }
    void OnTriggerEnter2D(Collider2D HitInfo)
    {
        audioManager.playSFX(audioManager.enemyHit);
        Debug.Log(HitInfo.name);
        Destroy(gameObject);
        Instantiate(Corpse,AnimationCenter.position,AnimationCenter.rotation);
    }

}
