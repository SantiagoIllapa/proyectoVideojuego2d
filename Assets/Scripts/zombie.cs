using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
    public Transform target;
    private new Rigidbody2D rigidbody2D;
    private SpriteRenderer body;
    private Animator animator;
    public float velocidadMov;
    public float tiempoReaccion;
    private Vector3 mov;
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        body = GetComponent<SpriteRenderer>();
        mov = new Vector3(velocidadMov, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
     
        rigidbody2D.transform.position = rigidbody2D.transform.position + mov;
    }
    private void perseguirJugador()
    {
        if (target.position.x < rigidbody2D.position.x)
        {
            body.flipX = false;
            mov.x = -velocidadMov;
        }
        else
        {
            body.flipX = true;
            mov.x = velocidadMov;
            
        }
    }
}
