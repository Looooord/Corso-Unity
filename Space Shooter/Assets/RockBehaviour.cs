using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehaviour : MonoBehaviour {

    float moveSpeed = 3f;
    int rotateToRight;

    private void Awake()
    {
        if (Random.Range(0, 2) == 0) rotateToRight = -1;
        else rotateToRight = 1; 
    }

    private void Update()
    {
        transform.Translate(moveSpeed * Vector3.down * Time.deltaTime);
        transform.Find("RockSprite").transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * 100 * rotateToRight); 
        if (transform.position.y < -5f)
        {
            Destroy(gameObject); 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.tag == "Player")
        {
            Debug.Log("You've been hit!");
            Destroy(collision.gameObject); 
            GameMaster GM = GameObject.Find("GM").GetComponent<GameMaster>();
            GM.GameOver(); 
        }
    }
}
