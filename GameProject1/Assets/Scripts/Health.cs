using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public bool isAlive = true;
    [SerializeField] private Healthbar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount; 
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
            isAlive = false;
            //Destroy(gameObject);
        }
    }

    
}