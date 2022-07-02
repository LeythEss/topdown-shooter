using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lethal : MonoBehaviour
{
    public float damage;
    public string enemyTag;
    GameObject[] bullet;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == enemyTag)
        {
            other.gameObject.GetComponent<healthManagment>().TakeDamage(damage);
            foreach (GameObject projectile in bullet)
            {
                Destroy(gameObject);
            }
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        bullet = GameObject.FindGameObjectsWithTag("projectile");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
