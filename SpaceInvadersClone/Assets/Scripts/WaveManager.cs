using Unity.VisualScripting;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] private FormationMovement formationMovement;

    void Awake()
    {
        formationMovement = GameObject.Find("FormationCenter").GetComponent<FormationMovement>();
    }
    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
