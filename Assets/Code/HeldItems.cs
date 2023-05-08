using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldItems : MonoBehaviour
{
    public FollowMouser fm;

    // Start is called before the first frame update
    void Start()
    {
        fm = FindObjectOfType<FollowMouser>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the mouse cursor
        Vector3 mousePos = Input.mousePosition;

        // Convert the mouse position to a world point
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        // Set the object's position to the mouse position
        transform.position = new Vector3(mousePos.x, mousePos.y, 0);

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Destroy(this.gameObject);
            fm.holdingSomething = false;
        }
    }
}
