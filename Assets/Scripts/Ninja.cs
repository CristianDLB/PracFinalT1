using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja : MonoBehaviour
{

    private Rigidbody2D body;
    private Animator animar;

    private const int correr = 0;
    private const int muere = 1;
    private const int salto = 2;

    public bool Muerte = false;
    public float velocidad = 10;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animar = GetComponent<Animator>();
    }
    void Update()
    {
        body.velocity = new Vector2(velocidad, body.velocity.y);
        changeAnimation(correr);

        if (Input.GetKey(KeyCode.Space)){
            body.velocity = new Vector2(body.velocity.x, 13);
            changeAnimation(salto);
        }
        if(Muerte == true)
        {
            changeAnimation(muere);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Debug.Log("Chocando Muero");
            muriendo();
        }
    }

    private void muriendo()
    {
        Muerte = true;
        velocidad = 0;
        changeAnimation(muere);
    }

    private void changeAnimation(int animation)
    {
        animar.SetInteger("Estado", animation);
    }

}
