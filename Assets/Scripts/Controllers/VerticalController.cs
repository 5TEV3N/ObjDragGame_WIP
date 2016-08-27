using UnityEngine;
using System.Collections;

public class VerticalController : MonoBehaviour
{
    public float distance = 10; // How far you can can drag an object 
    public Color highlightedVertical = new Color();

    private bool CanRotate;
    private Color initialColor;

    CursorLockMode clamp;

    public void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance); //Make a new Vector 3 which takes the position of your mouse's xy co ordinance
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition); //Make a Vector 3 value that takes the mouse position relative to your screen
        objPosition.x = transform.position.x; // limit from going to left to right
        transform.position = objPosition; // Transform the object to objPosition
        CanRotate = true;
        print("Mouse Drag of Vertical Platform is True");
    }

    void OnMouseEnter()
    {
        initialColor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = highlightedVertical;

    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = initialColor;
    }


    public void Rotate()
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
        if (Input.GetMouseButtonUp(0))
        {
            CanRotate = false;
            print("Mouse Drag of Vertical Platform is False");
        }

        Rotate();
    }
}
