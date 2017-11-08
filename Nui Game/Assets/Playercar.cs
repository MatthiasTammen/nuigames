using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercar : MonoBehaviour {

    public bool AddForce;
    private Rigidbody rb;
    private int score;
    public float movementSpeed = 2.0f;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        score = 0;
    }

    // Update is called once per frame
    void Update () {
		
	}
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.Rotate(0, 0, 1);

         }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.transform.Rotate(0, 0, -1);
        }
    }
}
