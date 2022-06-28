using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthManagment : MonoBehaviour
{
    public Behaviour[] disableOnDeath;
    public float health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

    void TakeDamage(float amount)
    {
       
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }

    void Die()
    {
        //Disable all the components inside the disableOnDeath array that you will assign from the inspector
        foreach (Behaviour behaviour in disableOnDeath)
        {
            behaviour.enabled = false;
            
        }
    }

}
