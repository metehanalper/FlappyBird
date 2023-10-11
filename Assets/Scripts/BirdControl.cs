using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private bool isDead;
    private float upForce;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        isDead = false;
        upForce = 200f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !isDead)
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, 1) * upForce);
            anim.SetTrigger("Flapp");
        }
    }

    void OnCollisionEnter2D(Collision2D othercollider2d)
    {
        isDead = true;
        anim.SetTrigger("Dead");
        GameControl.instance.BirdDied();

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        GameControl.instance.BirdScored();
    }
}
