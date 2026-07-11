using UnityEngine;

public class Disapear : MonoBehaviour
{
    private float AppearingTime = 0.0f;
    void Start()
    {
        AppearingTime = Time.time;
    }

    void Update()
    {
        if (Time.time > AppearingTime + 0.2f)
        {
            Destroy(gameObject);
        }
    }
}
