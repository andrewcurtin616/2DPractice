using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    SpriteRenderer spr;
    bool isGrounded;
    int spellIndex1;
    int spellIndex2;
    public GameObject shot;
    //List<GameObject> spells = new List<GameObject>(); //button simply instantiates it, script decides where it goes
    public List<SpellBase> spells = new List<SpellBase>();

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spr = GetComponentInChildren<SpriteRenderer>();
    }

    void Start()
    {
        //spells.Add(shot);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            spells[0].Cast();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            spells[1].Cast();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            spells[2].Cast();
        }

        //spell list
        //shield and/or melee

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

        //dash
        //double jump
    }

    void GetHit()
    {

    }
}
