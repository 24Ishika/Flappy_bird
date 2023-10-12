using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody BirdRigidbody;
    public float Force = 100f;
    public float Speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Space detected");
            BirdRigidbody.AddForce(transform.up * Force);
            Vector3 m_Input = new Vector3(00, 0, 50);


        }
        this.transform.Translate(Vector3.right * Speed);
    }
    void OnCollisionEnter(Collision collision)
    {
        GameObject temp = collision.gameObject;
        if (temp.tag == "Obstacle")
        {
            Debug.Log("Detected obstacle");
        }
        else if (temp.tag == "Score")
        {
            Debug.Log("score detected");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        int Score;

    }
   
}


