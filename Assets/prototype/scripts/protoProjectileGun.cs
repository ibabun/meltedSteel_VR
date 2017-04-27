using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protoProjectileGun : MonoBehaviour {
  
    public float thrust;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.forward * thrust);
       // transform.LookAt(targetPos);
        Destroy(this.gameObject, 2);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "traningTarget")
        {
            Debug.Log("KILLIT");
            //enemyHP = collision.gameObject.GetComponent<Health>();
            //enemyHP.CurrentHealth -= 5;

            //if (enemyHP.CurrentHealth < 10)
           // {
                Destroy(collision.gameObject);
           // }
           // Destroy(GetComponent<Collider>().gameObject);

        }
        Destroy(this.gameObject);
	}
}
