using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class EggScript : MonoBehaviour
{
    private Color startcolor;

    public ItemHolder itemHolder;

    void OnMouseEnter()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            itemHolder.hold.Add(this.gameObject);
            print("holder");
        }
        startcolor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = Color.gray;
    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startcolor;
    }
}
