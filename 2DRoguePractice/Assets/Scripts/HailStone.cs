using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HailStone : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
}
