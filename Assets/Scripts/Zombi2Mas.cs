using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombi2Mas : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator animar;
    private SpriteRenderer render;

    private const int normalSalto = 0;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animar = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Limite"))
        {
            Debug.Log("Funciona");
            body.velocity = new Vector2(body.velocity.x, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            Debug.Log("Funciona");
            body.velocity = Vector2.up * 10;
        }
    }


    private void changeAnimation(int animation)
    {
        animar.SetInteger("EstZom2", animation);
    }

}
