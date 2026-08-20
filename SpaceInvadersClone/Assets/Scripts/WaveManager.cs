using System;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] private FormationMovement formationMovement;
    public event Action<float> nextWave;
    private float wave = 1.0f;

    private bool stopInvokeNextWave = false;

    void Awake()
    {
        formationMovement = GameObject.Find("FormationCenter").GetComponent<FormationMovement>();
    }


    void Update()
    {
        if (formationMovement.isAllEnemyDead == true && !stopInvokeNextWave)
        {
            stopInvokeNextWave = true;
            wave +=1.0f;
            nextWave.Invoke(wave);
        }
    }
}
