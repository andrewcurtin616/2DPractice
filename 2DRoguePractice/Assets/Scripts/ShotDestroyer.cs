using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotDestroyer : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = Vector3.zero;
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
