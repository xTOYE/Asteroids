﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 20f;
    public float rotationSpeed = 360f;

    private Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.W))
        {
            rigid.AddForce(transform.up * speed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            rigid.AddForce(transform.up * -speed);
        }
    }
}
