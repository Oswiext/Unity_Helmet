using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool open;


    [Range(0, 20)]
    public float timer = 3.0f;

    private float randomSpawnDelay;

    float lastSpawnTime;

    private Renderer rend;

    [SerializeField]
    private Color colorToTurnTo = Color.white;
    private Color colorToTurnTo2 = Color.yellow;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        CloseDoor();
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Time.time > timer)
        {
            OpenDoor();

        }
        */

        //while(true)
           
    }

    private void OpenDoor()
    {
        //lastSpawnTime = Time.time;
        //randomSpawnDelay = Random.Range(spawnDelay - deltaRandomSpawn, spawnDelay + deltaRandomSpawn);
        //Instantiate(toolsPrefab);
        rend.material.color = colorToTurnTo;
        Debug.Log("open2");
    }

    private void CloseDoor()
        {
        //lastSpawnTime = Time.time;
        //randomSpawnDelay = Random.Range(spawnDelay - deltaRandomSpawn, spawnDelay + deltaRandomSpawn);
        //Instantiate(toolsPrefab);
        rend.material.color = colorToTurnTo2;
        Debug.Log("close");
    }
}
