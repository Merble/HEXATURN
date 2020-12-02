using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{
    private int color;

    void Update()
    {
        color = Random.Range(0, 4);
        switch (color)
        {
            case 0:
                GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 1:
                GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case 3:
                GetComponent<Renderer>().material.color = Color.green;
                break;
            case 4:
                GetComponent<Renderer>().material.color = Color.magenta;
                break;
        }
    }
}
