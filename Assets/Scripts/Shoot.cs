using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 0.01f;
    float fireElapsedTime = 0;
    public float fireDelay = 0.2f;

    void Start()
    {
        
        StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {

        fireElapsedTime += Time.deltaTime;

        if (fireElapsedTime >= fireDelay)
        {
            fireElapsedTime = 0;
            if (Input.GetMouseButton(0))
                Shot();

        }


    }
    void Shot()
    {

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet, 5f);
     
    }
    IEnumerator wait()
    {

        
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3f);

        
    }
    
}
