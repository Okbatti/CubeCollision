﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public Transform transform;
    public bool hitLeft;
    public bool hitRight;
    public bool leftmove;
    public bool rightmove;

    // Start is called before the first frame update
    void Start()
    {
        if (rightmove)
        {
            hitRight = true;
        }
        if (leftmove)
        {
            hitLeft = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        RightMovement();
    }

    public void RightMovement()
    {
        if (transform.position.x <= 50 && hitRight == true)
        {
            transform.position += new Vector3(20f * Time.deltaTime, 0, 0);
            if (transform.position.x > 50)
            {
                hitRight = false;
                hitLeft = true;
            }
        }
        if (hitLeft == true)
        {
            transform.position += new Vector3(-20f * Time.deltaTime, 0, 0);
            if (transform.position.x < -50)
            {
                hitRight = true;
                hitLeft = false;
            }
        }
    }

    public void LeftMovement()
    {
        if (transform.position.x >= 50 && hitLeft == true)
        {
            transform.position += new Vector3(20f * Time.deltaTime, 0, 0);
            if (transform.position.x > 50)
            {
                hitRight = true;
                hitLeft = false;
            }
        }
        if (hitRight == true)
        {
            transform.position += new Vector3(-20f * Time.deltaTime, 0, 0);
            if (transform.position.x < -50)
            {
                hitRight = false;
                hitLeft = true;
            }
        }
    }
}