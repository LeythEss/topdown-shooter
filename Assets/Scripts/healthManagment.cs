using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //At the top of the script

public class healthManagment : MonoBehaviour
{
    public Behaviour[] disableOnDeath;
    public float health;
    bool isdead = false;
    GameObject[] enemies;
    public Image healthbar; //Right before the void TakeDamage()


    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("zombie");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

    public void TakeDamage(float amount)
    {
        health -= amount;
        healthbar.fillAmount = health / 100; //In the void TakeDamage() 

        if (health <= 0)
        {
            health = 0;
            Die();
            destroyenemy();
        }   
    }

    public void Die()
    {
        //Disable all the components inside the disableOnDeath array that you will assign from the inspector
        foreach (Behaviour behaviour in disableOnDeath)
        {
            behaviour.enabled = false;
            isdead = true;
           
        }
        
        
            

    }
    void destroyenemy()
    {
        foreach (GameObject enemy in enemies)
        {
            if (isdead == true)
            {
                Destroy(gameObject);
            }
        }
    }
    

}
