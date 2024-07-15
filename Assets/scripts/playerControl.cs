using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class playerControl : MonoBehaviour
{
    private Rigidbody2D body;
    public float speed;
    public string walk;
    public string sprint;
    public string jump;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();  
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector2(-1, 1);
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            anim.SetBool(walk, true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool(sprint, true);
                transform.Translate(Vector2.left * speed * Time.deltaTime * 2);
            }
            else
            {
                anim.SetBool(sprint, false);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector2(1, 1);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            anim.SetBool(walk, true);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool(sprint, true);
                transform.Translate(Vector2.right * speed * Time.deltaTime * 2);
            }
            else
            {
                anim.SetBool(sprint, false);
            }
        }

        else
        {
            anim.SetBool(walk, false);
            anim.SetBool(sprint, false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(Vector2.up * 300);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            anim.SetBool(jump, true);
            anim.SetBool(walk, false);
            anim.SetBool(sprint, false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            anim.SetBool(jump, false);
        }
    }
}
