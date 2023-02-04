using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float fuerzaSalto;

    //private RigidBody2D rigidbody2d;
    private Animator animator;
    // Start is called before the first frame update
    void Stard()
    {
        animator = GetComponent<Animator>();
        //rigidbody2D = GetComponent<Rigidbody2d>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("estaSaltando", true);
            //rigidbody2D.AddForce(new Vector2(0, fuerzaSalto));
        }
    }

    private void OncollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            animator.SetBool("estaSaltando", false);
        }
    }
}
