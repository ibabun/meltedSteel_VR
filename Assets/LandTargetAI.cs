using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandTargetAI : MonoBehaviour {

    public GameObject Player;
    public Transform pTransform;
    public Rigidbody rb;


	// Use this for initialization
	void Start () {

        Player = GameObject.FindGameObjectWithTag("Player");
        pTransform = Player.transform;
	}
	
	// Update is called once per frame
	void Update () {

        rb.AddForce(transform.forward * 20);
        transform.LookAt(pTransform);
}
}
