using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lethal : MonoBehaviour
{
    public float damage;
    public string enemyTag;
    

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == enemyTag)
        {
            other.gameObject.GetComponent<healthManagment>().TakeDamage(damage);
            if (gameObject.tag == "projectile")
            {
                Destroy(gameObject);
            }
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
