using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance{get; private set;}
    public Vector2 limitz = new Vector2(-4,4);
    public Vector2 limity = new Vector2(2.35f,3.7f);
    public float velocity = 10f;
    public float velocitybuilding = 4f;
    [HideInInspector]
    public int score = 0;
    private bool gameOver = false;

    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }else
        {
            Instance = this;
        }
    }
    public bool GameIsActive()
    {
        return !gameOver;
    }
    public void GameOver()
    {
        gameOver = true;
        StartCoroutine(EndGame(4));
    }
    private IEnumerator EndGame(float time)
    {
        yield return new WaitForSeconds(time);
        string Scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(Scene);
    }
}
