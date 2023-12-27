using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Buildingmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!GameManager.Instance.GameIsActive())
        {
            return;
        }
        float moveseed = GameManager.Instance.velocitybuilding * Time.fixedDeltaTime;
        transform.position += new Vector3(0, 0, moveseed);
        if(transform.position.z >= 5)
        {
            Destroy(gameObject);
        }
    }
}
