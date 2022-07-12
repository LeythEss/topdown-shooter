using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //At the top of the script

public class healthManagment : MonoBehaviour
{
    public Behaviour[] disableOnDeath;
    public float health;
    
    GameObject[] enemies;
    public Image healthbar; //Right before the void TakeDamage()
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("zombie");
    }
   

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (gameObject.tag == "Player")
            healthbar.fillAmount = health / 100; //In the void TakeDamage() 

        if (health <= 0)
        {
            health = 0;
            Die();
            
        }   
    }

    public void Die()
    {
        //Disable all the components inside the disableOnDeath array that you will assign from the inspector
        foreach (Behaviour behaviour in disableOnDeath)
        {
            behaviour.enabled = false;
          
            if (gameObject.tag == "zombie")
                destroyenemy();
           
        }
        
        
            

    }
    void destroyenemy()
    {
        foreach(GameObject enemy in enemies)
        {
            Destroy(gameObject);
        }
    
           
        
    }
    

}
