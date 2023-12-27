using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    private float cooldown = 0f;
    public float interval = 0.5f;
    public GameObject projectile;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        bool shoot = Input.GetKey(KeyCode.RightControl);
        bool canshoot = cooldown <= 0f;
        if(shoot && canshoot)
        {

            Debug.Log(transform.position);
            Instantiate(projectile, transform.position, projectile.transform.rotation);
            cooldown = interval;
        }
    }
}
