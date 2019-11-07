using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelmetController : MonoBehaviour
{

    //list eller array?
    public List<Transform> positions = new List<Transform>();

    private int currentPosition = 0;

    //prenumerera på eventen från ButtonController
    private void OnEnable()
    {
        ButtonController.OnLeft += OnLeftPressed;
        ButtonController.OnRight += OnRightPressed;
    }

    // avsluta eventet buttoncontroller
    private void OnDisable()
    {
        ButtonController.OnLeft -= OnLeftPressed;
        ButtonController.OnRight -= OnRightPressed;
    }

    private void Start()
    {
        //allt som händer i denna klass när spelet startar metod
        UpdatePosition();
    }

    //metoder ursprung

        public void OnLeftPressed()
    {
        if(currentPosition > 0)
        {
            //ändrar position när leftpressed
            currentPosition--;
            //för att väl uppdatera
            UpdatePosition();
            Debug.Log ("Left");
        }
    }

    public void OnRightPressed()
    {
        if (currentPosition < positions.Count - 1)
        {
            currentPosition++;
            UpdatePosition();
            Debug.Log ("Right");
        }
    }

    public void UpdatePosition()
    {
        transform.position = positions[currentPosition].position;
    }
}
