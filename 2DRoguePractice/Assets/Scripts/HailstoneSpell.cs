using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HailstoneSpell : SpellBase
{
    public GameObject hailstone;
    Transform player;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    public override void Cast()
    {
        if (player == null)
            player = GameObject.Find("Player").transform;

        if (lastFire + rateOfFire > Time.time)
            return;

        //add left right sprite flip later
        int rndi = Random.Range(5, 8);
        int flip = player.GetComponentInChildren<SpriteRenderer>().flipX ? -1 : 1;
        for (int i = 0; i < rndi; i++)
        {
            float rnd = Random.Range(-15f, 15f);
            Instantiate(hailstone, player.position + Vector3.right * 0.25f * flip, 
                Quaternion.identity).transform.Rotate(Vector3.forward, rnd);
        }

        lastFire = Time.time;
    }
}
