using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrackScript : MonoBehaviour {

    private static float cameraAngle = 25f;

    public Transform target;

	void Start () {	
	}
	
	void Update () {

        // set a position slightly behind target
        float newX = target.transform.position.x;
        float newY = target.transform.position.y + 1.5f;
        float newZ = target.transform.position.z -2f;
        transform.position = new Vector3(newX, newY, newZ);


        // adjust rotation and lookdown angle

        float angle = target.transform.eulerAngles.y;

        transform.RotateAround(target.position, target.up, angle);
        transform.LookAt(target);
        transform.RotateAround(transform.position, transform.right, -1 * 25f);
	}
}
