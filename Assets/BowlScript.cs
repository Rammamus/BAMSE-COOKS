using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlScript : MonoBehaviour
{
    private Color startcolor;

    public bool canAdd = false;

    public int recipNum;

    public FollowMouser fm;

    //idk make shit get added accordingly

    public int flourAmount;
    public int flourMax;

    public int eggAmount;
    public int eggMax;
    
    public int sugarAmount;
    public int sugarMax;
    
    public int honeyAmount;
    public int honeyMax;

    public GameObject[] recipe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flourAmount >= flourMax)
        {
            recipNum = 0;
            recipe[recipNum].SetActive(true);
        }
    }

    private void OnMouseOver()
    {
        canAdd = true;
        if (fm.holdingSomething)
        {
            startcolor = GetComponent<Renderer>().material.color;
            GetComponent<Renderer>().material.color = Color.gray;
        }
    }

    private void OnMouseExit()
    {
        canAdd = false;
        GetComponent<Renderer>().material.color = startcolor;
    }
}
