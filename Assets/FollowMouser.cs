using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouser : MonoBehaviour
{
    public bool holdingSomething = false;

    public ItemHolder itemHolder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        // Get the current position of the mouse cursor
        Vector3 mousePos = Input.mousePosition;

        // Convert the mouse position to a world point
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        // Set the object's position to the mouse position
        transform.position = new Vector3(mousePos.x, mousePos.y, 0);

    }
}
