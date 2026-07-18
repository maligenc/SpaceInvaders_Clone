using UnityEngine;
using UnityEngine.UI;


public class HealtDisplay : MonoBehaviour
{
    
    public int healt;
    [SerializeField] private int maxHealt;
    [SerializeField] private Sprite spareShip;
    [SerializeField] private Sprite destroyedShip;
    [SerializeField] private Image[] ships;
    public PlayerLife playerLife;

    void Update()
    {
        healt = playerLife.HP;
        for (int i=0 ; i <ships.Length;i++)
        {
            if(i < healt)
            {
                ships[i].sprite=spareShip;
            }
            else
            {
                ships[i].sprite=destroyedShip;
            }
            if (i<maxHealt)
            {
                ships[i].enabled = true; 
            }
            else
            {
                ships[i].enabled=false;
            }
        }
    }
}
