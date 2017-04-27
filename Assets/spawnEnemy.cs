using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour {

    public GameObject enemy;

	// Use this for initialization
	void Start () {
        InvokeRepeating("spawn", 2.0f, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void spawn()
    {

        Instantiate(enemy, transform.position, transform.rotation);

    }

}
