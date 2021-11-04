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
        //StartCoroutine("ActivateRoomRoutine");
        foreach (Transform t in GetComponentsInChildren<Transform>(true))
        {
            t.gameObject.SetActive(true);
        }
    }

    IEnumerator ActivateRoomRoutine()
    {
        //wait for ui fade
        yield return new WaitForSeconds(1.2f);
        
        //activate everything
        foreach (Transform t in GetComponentsInChildren<Transform>(true))
        {
            t.gameObject.SetActive(true);
        }
    }

    public void DeactivateRoom()
    {
        //StartCoroutine("DeactiateRoomRoutine");
        foreach (Transform t in GetComponentsInChildren<Transform>())
        {
            if (t == transform)
                continue;
            t.gameObject.SetActive(false);
        }
    }
    IEnumerator DeactiateRoomRoutine()
    {
        //suspend enemies


        //wait for ui fade
        yield return new WaitForSeconds(1f);

        //deactivate everything
        foreach(Transform t in GetComponentsInChildren<Transform>())
        {
            if (t == transform)
                continue;
            t.gameObject.SetActive(false);
        }
    }
}
