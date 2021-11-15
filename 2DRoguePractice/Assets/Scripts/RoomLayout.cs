using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLayout : MonoBehaviour
{

    bool temp;
    void Start()
    {
        if (gameObject.name != "LevelLayout") //test
            temp = true;
    }

    void Update()
    {
        if (temp)
        {
            foreach (Transform t in GetComponentsInChildren<Transform>())
            {
                if (t == transform)
                    continue;
                t.gameObject.SetActive(false);
            }
            temp = false;
        }
    }

    public void ActivateRoom()
    {
        //enemies

        foreach (Transform t in GetComponentsInChildren<Transform>(true))
        {
            t.gameObject.SetActive(true);
        }
    }


    public void DeactivateRoom()
    {
        //enemies

        foreach (Transform t in GetComponentsInChildren<Transform>())
        {
            if (t == transform)
                continue;
            t.gameObject.SetActive(false);
        }
    }
    
}
