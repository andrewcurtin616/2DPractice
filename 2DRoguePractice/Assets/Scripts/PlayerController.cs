using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    SpriteRenderer spr;

    public GameObject shot;
    //List<GameObject> spells; //button simply instantiates it, script decides where it goes

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spr = GetComponentInChildren<SpriteRenderer>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        if (h != 0)
        {
            rb2d.velocity = new Vector2(h * 5, rb2d.velocity.y);
            //add slope handle here
            //run animation
            spr.flipX = h < 0 ? true : false;
        }
        else
        {
            //idle animation
        }

        if (Input.GetKeyDown(KeyCode.Space)) //&& grounded
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 8);
        }

        if (Input.GetKeyDown(KeyCode.K)) //&& rate of fire
        {
            /*int flip = spr.flipX ? -1 : 1;
            GameObject temp=
            Instantiate(shot, transform.position + Vector3.right * 0.25f*flip, Quaternion.identity);
            if (flip == -1)
                temp.transform.Rotate(0, 0, 180);*/
            Instantiate(shot);
        }


        //spell list
        //dash
        //double jump
        //shield

    }

    void GetHit()
    {

    }
}
