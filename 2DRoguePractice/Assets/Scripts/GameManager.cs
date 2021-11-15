using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    public static GameManager instance = null;

    PlayerController player;
    UIController userInterface;

    public static GameManager getInstance()
    {
        if (instance == null)
            instance = new GameManager();
        return instance;
    }

    public void SetPlayer(PlayerController player)
    {
        this.player = player;
    }

    public void SetUserInterface(UIController userInterface)
    {
        this.userInterface = userInterface;
    }

    ////////////////////////////////////////////////////////////////////////

    public void PlayerThroughDoor(Vector3 pos, RoomLayout currentRoom, RoomLayout nextRoom)
    {
        userInterface.FadeScreen();
        player.StartCoroutine("MovePlayerThroughDoor", pos);
        //player.PausePlayer();
        nextRoom.Invoke("ActivateRoom", 1.25f);
        currentRoom.Invoke("DeactivateRoom", 1.25f);
        //player.MovePlayer(pos);
        //player.StartCoroutine("MovePlayerRoutine", pos);
        //player.Invoke("UnPausePlayer", 1.75f);
    }

}
