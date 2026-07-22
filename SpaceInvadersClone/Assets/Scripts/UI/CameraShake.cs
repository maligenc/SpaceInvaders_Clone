using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]private float duration;
    public AnimationCurve animationCurve;

    public void ShakeCamera()
    {
        StartCoroutine(playCamera());
    }

    private IEnumerator playCamera()
    {
        float currentTime = 0;
        Vector3 originalPosition = transform.position;
        while(currentTime < duration)
        {
            transform.position = originalPosition + (Vector3)Random.insideUnitCircle * 0.1f;
            currentTime += Time.deltaTime;
            yield return null;
        }
        transform.position=originalPosition;
    }
}
