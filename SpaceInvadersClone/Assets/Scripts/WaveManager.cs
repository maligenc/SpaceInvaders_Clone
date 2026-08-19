using System;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] private FormationMovement formationMovement;
    public event Action<float> nextWave;
    private float wave = 1.0f;

    void Awake()
    {
        formationMovement = GameObject.Find("FormationCenter").GetComponent<FormationMovement>();
    }


    void Update()
    {
        if (formationMovement.isAllEnemyDead == true)
        {
            formationMovement.isAllEnemyDead = false;
            wave +=1.0f;
            nextWave.Invoke(wave);
        }
    }
}
