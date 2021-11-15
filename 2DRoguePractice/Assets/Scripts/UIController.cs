using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    Image fadePanel;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.getInstance();
        gameManager.SetUserInterface(this);
    }

    void Start()
    {
        fadePanel = GameObject.Find("FadePanel").GetComponent<Image>();
    }

    void Update()
    {
        
    }

    //maybe have a bool property that triggers just fade OR unfade rather than fade AND unfade
    public void FadeScreen() 
    {
        StartCoroutine("FadeScreenRoutine");
    }
    IEnumerator FadeScreenRoutine()
    {
        while(fadePanel.color.a < 1)
        {
            Color c = fadePanel.color;
            c.a += 0.1f;
            fadePanel.color = c;
            yield return new WaitForSeconds(.025f);
        }

        yield return new WaitForSeconds(1f);

        while (fadePanel.color.a > 0)
        {
            Color c = fadePanel.color;
            c.a -= 0.1f;
            fadePanel.color = c;
            yield return new WaitForSeconds(.025f);
        }
    }
}
