using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWheelSpell : SpellBase
{
    public GameObject fireWheel;
    Transform player;

    public override void Cast()
    {
        if (player == null)
            player = GameObject.Find("Player").transform;

        /*if (lastFire + rateOfFire < Time.time)
        {
            Instantiate(fireWheel, player.position, Quaternion.identity);
        }*/

        

        if (lastFire + rateOfFire > Time.time)
            return;

        foreach (FireWheel f in FindObjectsOfType<FireWheel>())
            Destroy(f.gameObject);

        for(int i = 1; i< 6; i++)
        {
            Instantiate(fireWheel, player.position, Quaternion.identity).transform.Rotate(Vector3.forward, 72*i);
        }
        lastFire = Time.time;

        /*Instantiate(fireWheel, player.position + Vector3.up * 2, Quaternion.identity);
        Instantiate(fireWheel, player.position + new Vector3(1.25f, -1.5f, 0), Quaternion.identity);
        Instantiate(fireWheel, player.position + new Vector3(-1.25f, -1.5f, 0), Quaternion.identity);
        Instantiate(fireWheel, player.position + new Vector3(1.75f, 0.75f, 0), Quaternion.identity);
        Instantiate(fireWheel, player.position + new Vector3(-1.75f, 0.75f, 0), Quaternion.identity);*/

        //using this with old fire wheel prefab would be a good empowered spell
    }
}
