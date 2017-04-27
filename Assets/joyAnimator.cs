using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joyAnimator : MonoBehaviour {

    public Transform JoyR; //Head_H Head_V
    public Transform JoyL; //Chassis_Z Chassis_X
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float Head_H = Input.GetAxis("Head_H") * 30;
        float Head_V = Input.GetAxis("Head_V") * 30;
        float Chass_Z = Input.GetAxis("Chassis_Z") * 20;
        float Chass_X = Input.GetAxis("Chassis_X") * 20;


        JoyR.localEulerAngles = new Vector3(-Head_V, 0f, -Head_H-90);
        JoyL.localEulerAngles = new Vector3(-Chass_Z, 0f, -Chass_X - 90);
	}
}
