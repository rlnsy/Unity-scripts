using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrackScript : MonoBehaviour {

    public Transform target;

	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
        
        float newX = target.transform.position.x;
        float newY = target.transform.position.y + 1.5f;
        float newZ = target.transform.position.z -2f;
        transform.position = new Vector3(newX, newY, newZ);

        //transform.rotation = target.transform.rotation;
        float angle = target.transform.eulerAngles.y;

        print(angle);

        //transform.rotation = Quaternion.AngleAxis(-1 * angle, target.up);

        //transform.LookAt(target);

        transform.RotateAround(target.position, target.up, angle);
        transform.LookAt(target);
        transform.RotateAround(transform.position, transform.right, -25f);
	}
}
