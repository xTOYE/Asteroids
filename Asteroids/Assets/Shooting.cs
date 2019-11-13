﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    public float shootRate = 0.2f;

    private float shootTimer = 0f;

    void Shoot()
    {
        GameObject clone = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rigid = clone.GetComponent<Rigidbody2D>();
        rigid.AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse);
    }

    private void Update()
    {
        shootTimer += Time.deltaTime;
        if(shootTimer >= shootRate)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Shoot();
                shootTimer = 0f;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Destroy(gameObject);
    }
}
