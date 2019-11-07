using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public bool left;

    //declare 2 events
    public delegate void ButtonPressed();
    public static event ButtonPressed OnLeft;
    public static event ButtonPressed OnRight;

    //onmousedown script framework. det vi skickar vidare sedan
    private void OnMouseDown()
    {
        //if mouse is down 
        if(OnLeft != null && left)
        {
            OnLeft(); //trigger the event
        }
        else if (OnRight != null)
        {
            OnRight(); //trigger the event
        }
    }

}
