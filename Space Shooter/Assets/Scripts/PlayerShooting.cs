using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public GameObject blast;
    Transform firePoint;

    private void Awake()
    {
        firePoint = transform.Find("FirePoint");
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Instantiate(blast, firePoint.position, Quaternion.identity);
        }
    }
}
