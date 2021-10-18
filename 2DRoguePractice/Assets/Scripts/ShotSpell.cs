using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpell : SpellBase
{
    public GameObject shot;

    public override void Cast()
    {
        if(lastFire + rateOfFire < Time.time)
        {
            Instantiate(shot);
            lastFire = Time.time;
        }
    }
}
