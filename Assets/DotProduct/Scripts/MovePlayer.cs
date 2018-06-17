using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {


    float speed = 3.0f;
    float rotationSpeed = 50.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}
