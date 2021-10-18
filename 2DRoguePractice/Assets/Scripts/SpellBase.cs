using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBase : MonoBehaviour
{
    public float rateOfFire;
    protected float lastFire;
    public int mana;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Cast()
    {
        //Error Message and/or default action
        //could use base cast to check for certain repetatve things as well
        //such as rate of fire checking
    }
}
