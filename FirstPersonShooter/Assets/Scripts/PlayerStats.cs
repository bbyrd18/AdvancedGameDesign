using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    
    private float currentHealth;

    public HealthBar healthBar;


    private void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetSliderMax(maxHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);
    }

    public void Heal(float amount)
    {
        currentHealth += amount;
        healthBar.SetSlider(currentHealth);
    }


    private void Update()
    {
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth <= 0)
        {
            Die(); 
        }
        
        
        
        
        //Testing damage by pressing the "K" key
        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(20f);
        }
    }

    private void Die()
    {
        Debug.Log("You died!");
        Destroy(this.gameObject);
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////Collisions///////////////////////////////////////////////////////////////////////////////////
    void OnTriggerEnter(Collider other) {
    {
        if (other.gameObject.tag == "medkit")
            print("Enter");
            Heal(20f);       
    }
    {
        if (other.gameObject.tag == "enemy")
            TakeDamage(25f);
            print("You hit an enemy");  
              
    }

    }

    void OnTriggerStay(Collider other)
    {
        
    }



    void OnTriggerExit(Collider other)
    {
        
    }


}
