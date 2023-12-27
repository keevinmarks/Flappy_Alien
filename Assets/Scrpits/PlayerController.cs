using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float cooldown = 0f;
    public float interval = 0.5f;
    private Rigidbody playerbody;
    public float powerjump = 10f;
    void Start()
    {
        playerbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(!GameManager.Instance.GameIsActive())
        {
            return;
        }
        cooldown -= Time.deltaTime;
        bool canjump = cooldown <= 0f;
        bool jump = Input.GetKey(KeyCode.Space);
        if(jump && canjump)
        {
            //Zerar velocidade
            playerbody.velocity = Vector3.zero;
            //Aplicar impulso
            playerbody.AddForce(new Vector3(0, powerjump, 0),ForceMode.Impulse);
            cooldown = interval;
            
        }
    }
    private void OnTriggerEnter(Collider Colisor)
    {
        DetectCollision(Colisor.gameObject);
    }
    private void OnCollisionEnter(Collision Colisor)
    {
        DetectCollision(Colisor.gameObject);
    }
    private void DetectCollision(GameObject obj)
    {
        if(!obj.CompareTag("Sensor"))
        {
            GameManager.Instance.GameOver();
        }else
        {
            GameManager.Instance.score ++;
            Debug.Log("Score: " + GameManager.Instance.score);
        }
    }
}
