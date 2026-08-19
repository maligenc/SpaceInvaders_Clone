using UnityEngine;
using TMPro;
using System;
using System.Runtime.CompilerServices;

public class WaveDisplay : MonoBehaviour
{
    private WaveManager waveManager;
    private TMP_Text waveText;

    void Awake()
    {
        waveText = GetComponent<TMP_Text>();
        waveManager = GameObject.Find("GameManager").GetComponent<WaveManager>();
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
        waveText.text = $"Wave {wave}";
    }
}
