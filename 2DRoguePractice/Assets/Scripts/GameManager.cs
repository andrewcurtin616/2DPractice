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

    public void PlayerThroughDoor(Vector3 pos) //could pass in pos, current room, and next room
    {
        userInterface.FadeScreen();
        player.PausePlayer();
        player.MovePlayer(pos);
        player.Invoke("UnPausePlayer", 1.75f);
    }

}
