using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinAttach : MonoBehaviour {

    public GameObject spinebone;
    public botController botController;
    public bool getRotate;
    public bool spwned;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = spinebone.transform.position;
        spwned = botController.GetComponent<botController>().spwned;

        if(!spwned) // не даём крутить башней во время спавна
        {
            this.transform.rotation = spinebone.transform.rotation;
        }
	}
}
