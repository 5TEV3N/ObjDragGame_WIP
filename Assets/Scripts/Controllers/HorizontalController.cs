using UnityEngine;
using System.Collections;

public class HorizontalController : MonoBehaviour
{
    public float distance = 10; // How far you can can drag an object 
    bool CanRotate;

    public void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance); //Make a new Vector 3 which takes the position of your mouse's xy co ordinance
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition); //Make a Vector 3 value that takes the mouse position relative to your screen
        objPosition.y = transform.position.y; // limit from going to left to right
        transform.position = objPosition; // Transform the object to objPosition
    }


    public void Rotate(bool CanRotate)
    {
        if (CanRotate == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                gameObject.transform.Rotate(0, 0, 1.5f);
            }

            if (Input.GetKey(KeyCode.Q))
            {
                gameObject.transform.Rotate(0, 0, -1.5f);
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CanRotate = true;
            print("true");
        }
        if (Input.GetMouseButtonUp(0))
        {
            CanRotate = false;
            print("false");
        }

        Rotate(CanRotate);
    }
}