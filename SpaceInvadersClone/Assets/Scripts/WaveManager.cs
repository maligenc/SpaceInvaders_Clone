using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveManager : MonoBehaviour
{
    public static WaveManager Instance {get; private set;}
    [SerializeField] private FormationMovement formationMovement;
    public event Action<float> nextWave;
    public float wave = 1.0f;

    public bool stopInvokeNextWave = false;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            return;
        }
        Instance = this;
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += ResetWave;
        SceneManager.sceneLoaded += GetNewFormation;
    }
    void OnDisable()
    {
        SceneManager.sceneLoaded -= ResetWave;
        SceneManager.sceneLoaded -= GetNewFormation;
    }

    void Update()
    {
        if (formationMovement.isAllEnemyDead == true && !stopInvokeNextWave)
        {
            stopInvokeNextWave = true;
            wave +=1.0f;
            nextWave?.Invoke(wave);
        }
    }
    void ResetWave(Scene scene,LoadSceneMode loadSceneMode)
    {
        if(scene.name == "Level1")
        {
            wave = 1.0f;
            stopInvokeNextWave = false;
        }
    }
    void GetNewFormation(Scene scene,LoadSceneMode loadSceneMode)
    {
        if(scene.name == "Level1")
        {
            formationMovement = GameObject.Find("FormationCenter").GetComponent<FormationMovement>();
        }
    }
}
