using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAftermath : MonoBehaviour
{
    private float countDown;
    public GameObject explosionEffect;
    public float Delay = .5f;

    public Vector3 scaleIncrease = new Vector3 (0.002f, 0.002f, 0.002f);
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
            explode();
        }
    }
    void FixedUpdate(){
        explosionEffect.transform.localScale += scaleIncrease;
    }

    void explode(){
        Destroy(gameObject);
    }
}
