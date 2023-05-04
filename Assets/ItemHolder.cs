using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour
{
    public List<GameObject> hold = new List<GameObject>();
    public List<GameObject> recipe = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) //&& hoveringBowl == true)
        {

        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //remove hold
        }
    }
}
