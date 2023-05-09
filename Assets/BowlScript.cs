using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlScript : MonoBehaviour
{
    public bool canAdd = false;

    public int recipNum;


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
    }

    private void OnMouseExit()
    {
        canAdd = false;
    }
}
