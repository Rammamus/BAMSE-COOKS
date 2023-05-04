using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class EggScript : MonoBehaviour
{
    private Color startcolor;
    void OnMouseEnter()
    {
        startcolor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = Color.gray;
    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startcolor;
    }
}
