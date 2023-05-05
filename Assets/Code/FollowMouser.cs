using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouser : MonoBehaviour
{
    public bool holdingSomething = false;

    public TableItems tableItems;

    public GameObject[] prefabs;
    public Transform spawnPoint;
    public int prefabNum;

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


        //CAN SPAWN WHEN HOVER ANNNNYYYYYYY ITEM!!!!!
        if (Input.GetKeyDown(KeyCode.Mouse0) && tableItems.isHovering == true)
        {
            Instantiate(prefabs[prefabNum], spawnPoint.position, Quaternion.identity);
        }
    }
}
