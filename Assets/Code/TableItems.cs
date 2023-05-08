using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class TableItems : MonoBehaviour
{
    private Color startcolor;

    public FollowMouser fm;

    public int numInArray;
    void OnMouseEnter()
    {
        startcolor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = Color.gray;
        fm.isHovering = true;
        fm.prefabNum = numInArray;
    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startcolor;
        fm.isHovering = false;
    }
}
