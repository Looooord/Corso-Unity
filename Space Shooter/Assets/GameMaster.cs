using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameMaster : MonoBehaviour {

	public GameObject rocksSpawnerPrefab;
    public GameObject playerShipPrefab;
    public Text gameOverText;
    public Text startText;
    public Text scoreText;
    int scoreAmount = 0; 
    GameObject rocksSpawner;
    bool spawning = false;
    Vector3 spawnPos;

    static GameMaster gm;

    private void Awake()
    {
        gm = this;
        spawnPos = new Vector3(0, 0, 0);
        startText.gameObject.SetActive(true);
    }


    private void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            if (!spawning)
            {
                gameOverText.gameObject.SetActive(false); 
                startText.gameObject.SetActive(false);
                scoreText.gameObject.SetActive(true);
                rocksSpawner = Instantiate(rocksSpawnerPrefab);
                Instantiate(playerShipPrefab, spawnPos, Quaternion.identity); 
                spawning = true; 
            }
        }
    }

    public void GameOver()
    {
        scoreText.gameObject.SetActive(false); 
        Destroy(rocksSpawner);
        spawning = false;
        gameOverText.gameObject.SetActive(true);
        startText.gameObject.SetActive(true); 
    }

    public static void IncrementScore()
    {
        gm.scoreAmount += 100; 
        gm.scoreText.text = gm.scoreAmount.ToString(); 
    }



    
}
