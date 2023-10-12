using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleSetup : MonoBehaviour
{
    public GameObject ObstaclePrefab;


    public float gap  = 5f;
    public float scale = 16f;
    public float currX = 0f;

    public float yPos = 5;


    // Start is called before the first frame update
    void Start()
    {
        Setup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setup()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject upperCube = Spawn();
            GameObject lowerCube = Spawn();

            upperCube.transform.position = new Vector3(currX, yPos,0);
            lowerCube.transform.position = new Vector3(currX, -yPos, 0);

            SetScale(upperCube,lowerCube);

            currX += gap;

        }
           
    }

    public void SetScale (GameObject upperCube , GameObject lowerCube)
    {
        // calculation :-
        float up = Random.Range(2, 14);
        float down = scale - up;
        upperCube.transform.localScale = new Vector3(1, up , 1);
        lowerCube.transform.localScale = new Vector3(1, down , 1);
    }

    public GameObject Spawn() 
    {
        GameObject temp = Instantiate(ObstaclePrefab);
        return temp;
    }

    public void SetPosition() 
    {
    
    }
}
