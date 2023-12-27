using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float interval = 2f;
    private float cooldown = 0f; 
    public List<GameObject> prefabs;
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
        GameManager Game = GameManager.Instance;
        // Pegar um obstaculo na lista
        cooldown -= Time.deltaTime;
        if(cooldown <= 0f){
            GameObject obstacle = prefabs[Random.Range(0,prefabs.Count)];
            float highy = Random.Range(Game.limity.x, Game.limity.y);
            float inicialz = Game.limitz.x;
            Vector3 position = new Vector3(0.396f, highy, inicialz);
            Quaternion rotation = obstacle.transform.rotation;
            Instantiate(obstacle, position, rotation);
            cooldown = interval;
        }
    }
}
