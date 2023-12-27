using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody body;
    private float cooldown = 3f;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.AddForce(new Vector3(0, 0, -10), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if(cooldown <= 0)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter(Collision barreira)
    {
        if(barreira.gameObject.CompareTag("Barrier"))
        {
            Destroy(barreira.gameObject);
        }
    }
}
