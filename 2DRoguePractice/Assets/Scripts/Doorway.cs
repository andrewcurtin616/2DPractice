using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorway : MonoBehaviour
{
    //[HideInInspector]
    public RoomLayout myRoom;
    public Doorway nextDoor;
    public Vector3 doorPlayerPos;

    private void Start()
    {
        myRoom = GetComponentInParent<RoomLayout>();
        doorPlayerPos = transform.position - Vector3.up * 0.5f-(GetComponent<BoxCollider2D>().offset.x*5)*Vector3.right;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GoThroughDoor();
        }
    }

    void GoThroughDoor()
    {
        if (nextDoor == null || nextDoor.myRoom == null)
            return;
        GameManager.getInstance().PlayerThroughDoor(nextDoor.doorPlayerPos);
        Invoke("SwitchRooms", 1.25f);
    }
    void SwitchRooms()
    {
        nextDoor.myRoom.ActivateRoom();
        myRoom.DeactivateRoom();
    }
}
