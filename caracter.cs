using UnityEngine;
using System.Collections;
using System;

public class caracter : MonoBehaviour
{
    public float hiz, ziplamaGucu;
    public bool yerdeMi;

    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * h * hiz);
    }

}