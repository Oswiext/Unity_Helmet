using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsController : MonoBehaviour
{
    //so we can clone
    [SerializeField]
    private List<Transform> positions = new List<Transform>();

    public int currentPosition = 0;

    float lastMoveTime;
    float moveDelay = 1.0f;

    private void Start()
    {
        transform.position = positions[currentPosition].position;
        lastMoveTime = Time.time;

        //monobehaviour class. multitasking resume and suspend
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        while (true)
        {
            yield return new WaitForSeconds(moveDelay);
            MoveToNextPosition();
        }
    }



    void MoveToNextPosition()
    {
        currentPosition++;

        if (currentPosition >= positions.Count)
        {

            GameObject parent = transform.parent.gameObject;
            Destroy(parent);

            //gameObject.SetActive(false);
            // currentPosition = 0;
            // ta bort vår jumper och eventuellt ge poäng
        }
        else
        {
            transform.position = positions[currentPosition].position;
        }

    }

}