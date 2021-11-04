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
    public bool isPaused;

    GameManager gameManager;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spr = GetComponentInChildren<SpriteRenderer>();
        gameManager = GameManager.getInstance();
        gameManager.SetPlayer(this);
    }

    void Start()
    {
        //spells.Add(shot);
    }

    void Update()
    {
        if (isPaused)
            return;

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
        if (isPaused)
            return;

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

    public void MovePlayer(Vector3 pos)
    {
        StartCoroutine("MovePlayerRoutine", pos);
        //transform.position = pos;
    }
    IEnumerator MovePlayerRoutine(Vector3 pos)
    {
        yield return new WaitForSeconds(1f);
        transform.position = pos;
    }

    public void PausePlayer()
    {
        isPaused = true;
        //hitbox
        rb2d.gravityScale = 0;
    }
    public void UnPausePlayer()
    {
        isPaused = false;
        //hitbox
        rb2d.gravityScale = 1;
    }
}
