using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //ignore player collision
        //Destroy(gameObject, 10);
        //play sound
        GameObject player = GameObject.Find("Player");
        if (player.GetComponentInChildren<SpriteRenderer>().flipX)
        {
            transform.position = player.transform.position + Vector3.left * 0.25f;
            transform.Rotate(0, 0, 180);
        }
        else
        {
            transform.position = player.transform.position + Vector3.right * 0.25f;
        }
    }

    void Update()
    {
        transform.position += transform.right*speed*Time.deltaTime;
        //if (Mathf.Abs(transform.position.x) >= 50)
            //Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player"))
            Debug.Log("Hit");
        //sound
    }
}
