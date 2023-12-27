using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barreirmove : MonoBehaviour
{
    private float randomint;
    public float interval = 1f;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        randomint = Random.Range(0,6);
    }

    // Update is called once per frame
    void Update()
    {
        
        bool canUp = randomint == 5;
        if(canUp)
        {
            if(interval > 0f)
            {
                interval -= Time.deltaTime;
                float movespeed = speed * Time.deltaTime;
                transform.position += new Vector3(0, movespeed, 0);
            }else
            {
                return;
            }
        }
        
    }
}
