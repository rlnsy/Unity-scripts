using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

    float moveSpeed = 5f;
    float rotationAngle;

	// Use this for initialization
	void Start () {
        rotationAngle = 0f;	
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }


        // move

        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);    
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            Turn(true);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            Turn(false);
        }

	}

    void Turn(bool leftTurn) {
        rotationAngle += 5f * (leftTurn ? -1 : 1);
        Quaternion rotation = Quaternion.AngleAxis(rotationAngle, transform.up);
        transform.localRotation = rotation;
    }

    float getRotation() {
        return rotationAngle;
    }
}
