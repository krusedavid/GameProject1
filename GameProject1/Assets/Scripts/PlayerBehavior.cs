using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void PlayerTakeDmg(int dmg)
    {
        GameManager.gameManager.playerHealth.DmgUnit(dmg);
        Debug.Log(GameManager.gameManager.playerHealth.Health);
    }
}
