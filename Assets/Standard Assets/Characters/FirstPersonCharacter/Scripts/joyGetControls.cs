using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joyGetControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//getting AXYS iputs

        float axis1 = Input.GetAxis("a1");
        float axis2 = Input.GetAxis("a2");
        float axis3 = Input.GetAxis("a3");
        float axis4 = Input.GetAxis("a4");
        float axis5 = Input.GetAxis("a5");
        float axis6 = Input.GetAxis("a6");
        float axis7 = Input.GetAxis("a7");
        float axis8 = Input.GetAxis("a8");
        float axis9 = Input.GetAxis("a9");
        float axis10 = Input.GetAxis("a10");
        float axis11 = Input.GetAxis("a11");
        float axis12 = Input.GetAxis("a12");
        float axis13 = Input.GetAxis("a13");
        float axis14 = Input.GetAxis("a14");
        float axis15 = Input.GetAxis("a15");
        float axis16 = Input.GetAxis("a16");
        float axis17 = Input.GetAxis("a17");
        float axis18 = Input.GetAxis("a18");
        float axis19 = Input.GetAxis("a19");
        float axis20 = Input.GetAxis("a20");
        float axis21 = Input.GetAxis("a21");
        float axis22 = Input.GetAxis("a22");
        float axis23 = Input.GetAxis("a23");
        float axis24 = Input.GetAxis("a24");
        float axis25 = Input.GetAxis("a25");
        float axis26 = Input.GetAxis("a26");
        float axis27 = Input.GetAxis("a27");
        
        //logging AXYS inputs

        if (axis1 != 0)
        {
            Debug.Log("axis1_" + axis1);
        }

        if (axis2 != 0)
        {
            Debug.Log("axis2_" + axis2);
        }

        if (axis3 != 0)
        {
            Debug.Log("axis3_" + axis3);
        }

        if (axis4 != 0)
        {
            Debug.Log("axis4_" + axis4);
        }

        if (axis5 != 0)
        {
            Debug.Log("axis5_" + axis5);
        }

        if (axis6 != 0)
        {
            Debug.Log("axis6_" + axis6);
        }

        if (axis7 != 0)
        {
            Debug.Log("axis7_" + axis7);
        }

        if (axis8 != 0)
        {
            Debug.Log("axis8_" + axis8);
        }

        if (axis9 != 0)
        {
            Debug.Log("axis9_" + axis9);
        }

        if (axis10 != 0)
        {
            Debug.Log("axis10_" + axis10);
        }

        if (axis11 != 0)
        {
            Debug.Log("axis11_" + axis11);
        }

        if (axis12 != 0)
        {
            Debug.Log("axis12_" + axis12);
        }

        if (axis13 != 0)
        {
            Debug.Log("axis13_" + axis13);
        }

        if (axis14 != 0)
        {
            Debug.Log("axis14_" + axis14);
        }

        if (axis15 != 0)
        {
            Debug.Log("axis15_" + axis15);
        }

        if (axis16 != 0)
        {
            Debug.Log("axis16_" + axis16);
        }

        if (axis17 != 0)
        {
            Debug.Log("axis17_" + axis17);
        }

        if (axis18 != 0)
        {
            Debug.Log("axis18_" + axis18);
        }

        if (axis19 != 0)
        {
            Debug.Log("axis19_" + axis19);
        }

        if (axis20 != 0)
        {
            Debug.Log("axis20_" + axis20);
        }

        if (axis21 != 0)
        {
            Debug.Log("axis21_" + axis21);
        }

        if (axis22 != 0)
        {
            Debug.Log("axis22_" + axis22);
        }

        if (axis23 != 0)
        {
            Debug.Log("axis23_" + axis23);
        }

        if (axis24 != 0)
        {
            Debug.Log("axis24_" + axis24);
        }

        if (axis25 != 0)
        {
            Debug.Log("axis25_" + axis25);
        }

        if (axis26 != 0)
        {
            Debug.Log("axis26_" + axis26);
        }

        if (axis27 != 0)
        {
            Debug.Log("axis27_" + axis27);
        }

        //getting BUTTON INPUTS

        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            Debug.Log("button0");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            Debug.Log("button1");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            Debug.Log("button2");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            Debug.Log("button3");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton4))
        {
            Debug.Log("button4");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton5))
        {
            Debug.Log("button5");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton6))
        {
            Debug.Log("button6");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton7))
        {
            Debug.Log("button7");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton8))
        {
            Debug.Log("button8");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton9))
        {
            Debug.Log("button9");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton10))
        {
            Debug.Log("button10");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton11))
        {
            Debug.Log("button11");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton12))
        {
            Debug.Log("button12");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton13))
        {
            Debug.Log("button13");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton14))
        {
            Debug.Log("button14");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton15))
        {
            Debug.Log("button15");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton16))
        {
            Debug.Log("button16");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton17))
        {
            Debug.Log("button17");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton18))
        {
            Debug.Log("button18");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton19))
        {
            Debug.Log("button19");
        }


	}
}
