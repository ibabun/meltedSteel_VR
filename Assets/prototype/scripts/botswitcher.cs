using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botswitcher : MonoBehaviour {



    public GameObject botv1;
    public GameObject botv2;

    public bool bv1 = true;
    public bool bv2 = false;

	// Use this for initialization
	void Start () {




	}
	
	// Update is called once per frame
	void Update () {

       // if (bv1)
       // {
        //    botv1.SetActive(true);
        //    botv2.SetActive(false);
       // }

       // if (bv2)
       // {
        //    botv2.SetActive(true);
        //    botv1.SetActive(false);
       // }
        
        if (Input.GetKeyDown(KeyCode.JoystickButton8) && bv1)
        {
           bv1 = false;
           bv2 = true;
              botv1.SetActive(false);
              botv2.SetActive(true);
            Debug.Log("D1");
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton9) && bv2)
        {
            bv1 = true;
            bv2 = false;
            botv1.SetActive(true);
            botv2.SetActive(false);
            Debug.Log("D2");
        }


	}
}
