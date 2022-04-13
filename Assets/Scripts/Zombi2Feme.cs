using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombi2Feme : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator animar;
    private SpriteRenderer render;

    private const int normalS = 0;

    public bool cambio = true;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        render.flipX = false;
        if(cambio == false)
        {
            render.flipX = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Limite"))
        {
            Debug.Log("Funciona2");
            body.velocity = new Vector2(body.velocity.x, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            Debug.Log("Funciona");
            body.velocity = Vector2.up * 10;
            Debug.Log("Volteando");
            cambio = false;
        }
    }

}
