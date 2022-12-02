using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float fuerzaSalto;
    private new Rigidbody2D rigidbody2D;
    private SpriteRenderer body;
    private Animator animator;
    int salud=0;
    private bool isJump=false;
    private bool isAtack=false;
    public float velocidadMov;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D= GetComponent<Rigidbody2D>();
        body= GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (isJump == false)
            {
                isJump = true;
                animator.SetBool("Jump", true);
                rigidbody2D.AddForce(new Vector2(0, fuerzaSalto));
            }
            
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetInteger("Speed", 0);
            animator.SetInteger("Attack", 1);
           

        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            animator.SetInteger("Attack", 0);
        }
       
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetInteger("Speed", 1);
            body.flipX = true;
            rigidbody2D.transform.position = rigidbody2D.transform.position + new Vector3(velocidadMov, 0,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetInteger("Speed", 1);
            body.flipX = false;
            rigidbody2D.transform.position = rigidbody2D.transform.position - new Vector3(velocidadMov, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetInteger("Speed", 0);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetInteger("Speed", 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            isJump = false;
            animator.SetBool("Jump", false);
        }
    }
}
