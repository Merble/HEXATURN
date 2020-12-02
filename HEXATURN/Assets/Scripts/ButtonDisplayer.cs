using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDisplayer : MonoBehaviour
{
    //public bool active = false;
    public GameObject displayer;

    public GameObject credits;

    public void ButtonDisplay()
    {
        displayer.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(credits.transform.position.y >= 600)
        {
            ButtonDisplay();
        }
    }
}
