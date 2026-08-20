using UnityEngine;
using TMPro;
using System;
using System.Collections;

public class WaveDisplay : MonoBehaviour
{
    private WaveManager waveManager;
    private TMP_Text waveText;
    private float wavecount =0f;
    [SerializeField] private float enableTimeWindow = 0f;
    [SerializeField] private float disableTimeWindow = 0f;
    [SerializeField] private float totalDisplayTime = 0f;

    public event Action<float> spawnNextWave;

    void Awake()
    {
        waveText = GetComponent<TMP_Text>();
        waveManager = GameObject.Find("GameManager").GetComponent<WaveManager>();
        waveText.enabled=false;
    }

    void OnEnable()
    {
        waveManager.nextWave += StartDisplay;
    }

    void OnDisable()
    {
        waveManager.nextWave -= StartDisplay;
    }

    void StartDisplay(float wave)
    {
        wavecount = wave;
        waveText.text = $"Wave {wave}";
        StartCoroutine(blinkingWaveDisplay());
    }

    private IEnumerator blinkingWaveDisplay()
    {
        float currentTime =0f;
        while(currentTime < totalDisplayTime)
        {
            if (!waveText.enabled)
            {
                waveText.enabled = true;
                yield return new WaitForSeconds(enableTimeWindow);
                currentTime += enableTimeWindow;
            }
            waveText.enabled = false;
            yield return new WaitForSeconds(disableTimeWindow);
            currentTime += disableTimeWindow;
        }
        waveText.enabled = false;
        spawnNextWave.Invoke(wavecount);
    }
}
