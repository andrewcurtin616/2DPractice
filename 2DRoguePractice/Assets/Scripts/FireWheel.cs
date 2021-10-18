using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWheel : MonoBehaviour
{
    Transform player;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        transform.Rotate(Vector3.forward * Time.deltaTime * 125);
    }
}
