using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NadeExplosion : MonoBehaviour
{
    private float countDown;
    public GameObject explosionEffect;
    public float Delay = .5f;
    public float grenadeRadius = 2000f;
    public float ExplosionForce = 7000f;
    //public float DamageRate = 60f;
    // Start is called before the first frame update
    void Start()
    {
         countDown = Delay;
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0f)
        {
            Explode();
        }
    }

        private void Explode()
    {
        
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        //Collider[] touchedObjects = Physics.OverlapSphere(transform.position, grenadeRadius).Where(x => x.tag == "Enemy").ToArray();
 
        // foreach (Collider touchedObject in touchedObjects)
        // {
        //     Rigidbody rigidbody = touchedObject.GetComponent<Rigidbody>();
        //     if(rigidbody != null)
        //     {
        //         rigidbody.AddExplosionForce(ExplosionForce, transform.position, grenadeRadius);
        //     }
 
        //     // var target = touchedObject.gameObject.GetComponent<EnemyMovment>();
        //     // target.TakeDamage(DamageRate);
 
        // }
        // Destroy(gameObject);
    }   
        
    
}
