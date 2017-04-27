using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimController : MonoBehaviour {

    public Transform VRCamera_transform;

    private float rotationY = 0f;
    private float rotationX = 0f;

    private float calcX = 0f;
    private float calcY = 0f;

    public Transform gun1;
    public Transform gun2;
    public Transform protoBotHead;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = VRCamera_transform.position;


        if (VRCamera_transform.localEulerAngles.x > 330)
        { 
            rotationX = VRCamera_transform.localEulerAngles.x;
        }
        
        if (VRCamera_transform.localEulerAngles.x < 30)
        {
            rotationX = VRCamera_transform.localEulerAngles.x;
        }

        if (VRCamera_transform.localEulerAngles.y > 330)
        {
            rotationY = VRCamera_transform.localEulerAngles.y;
        }

        if (VRCamera_transform.localEulerAngles.y < 30)
        {
            rotationY = VRCamera_transform.localEulerAngles.y;
        }


            this.transform.localEulerAngles = new Vector3(rotationX, rotationY, VRCamera_transform.localEulerAngles.z);
            //Debug.Log("rx = " + VRCamera_transform.localEulerAngles.x);
           // Debug.Log("ry = " + VRCamera_transform.localEulerAngles.y);
            gun1.transform.localEulerAngles = new Vector3(-rotationX, rotationY, VRCamera_transform.localEulerAngles.z);
            gun2.transform.localEulerAngles = new Vector3(-rotationX, rotationY, VRCamera_transform.localEulerAngles.z);
            //protoBotHead.transform.localEulerAngles = new Vector3(rotationX/10, rotationY/10, VRCamera_transform.localEulerAngles.z/100);

	}
}
