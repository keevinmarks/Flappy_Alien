using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuldingSpawner : MonoBehaviour
{
    public List<GameObject> prefabs;
    private float cooldown = 0f;
    public float intervalbuil = 1f;
    private Vector3 origem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.Instance.GameIsActive())
        {
            return;
        }
        cooldown -= Time.deltaTime;
        if(cooldown <= 0f){
            int indexbuild = Random.Range(0,prefabs.Count);
            GameObject prefab = prefabs[indexbuild];
            if(indexbuild == 0)
            {
                origem = new Vector3(2.098f,-2.4089f,-3.578f);
            }else if(indexbuild == 1)
            {
                origem = new Vector3(2.0659f,-2.3849f,-3.575f);
            }else if(indexbuild == 2)
            {
                origem = new Vector3(2.069f,-2.404f,-3.5759f);
            }else if(indexbuild == 3)
            {
                origem = new Vector3(2.059f,-2.4f,-5.598f);
            }
            Instantiate(prefab, origem, prefab.transform.rotation);
            cooldown = intervalbuil;
        }
    }
}
