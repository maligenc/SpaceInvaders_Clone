using UnityEngine;

public class Box_death : MonoBehaviour
{
    public Transform AnimationCenter;
    public GameObject Corpse;

    void OnTriggerEnter2D(Collider2D HitInfo)
    {
        Debug.Log(HitInfo.name);
        Destroy(gameObject);
        Instantiate(Corpse,AnimationCenter.position,AnimationCenter.rotation);
    }

}
