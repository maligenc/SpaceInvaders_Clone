using UnityEngine;
using TMPro;

public class WaveDisplayController : MonoBehaviour
{
    private WaveManager waveManager;
    private float wave =0f;
    private TMP_Text waveText;
    void Start()
    {
        waveText = GetComponent<TMP_Text>();
        waveManager = GameObject.Find("GameManager").GetComponent<WaveManager>();
        wave = waveManager.wave;
    }


    void Update()
    {
        waveText.text = $"Wave : {(int)wave}";
    }
}
