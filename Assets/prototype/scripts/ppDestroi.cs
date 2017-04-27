using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ppDestroi : MonoBehaviour {
    public GameObject projectile;
    public GameObject Prefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = projectile.transform.position;
        Destroy(this.gameObject, 7);	
	}
}
