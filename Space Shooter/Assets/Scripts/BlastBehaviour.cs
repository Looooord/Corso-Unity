using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastBehaviour : MonoBehaviour {

    float moveSpeed = 7.5f;

    private void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        Destroy(gameObject, 5f); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.GetComponent<RockBehaviour>() != null)
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GameMaster.IncrementScore(); 
        }
    }
}
