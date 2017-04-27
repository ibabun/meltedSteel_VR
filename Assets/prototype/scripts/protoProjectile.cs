using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protoProjectile : MonoBehaviour {
    public float thrust;
    public Rigidbody rb;
    public GameObject locator;
    public GameObject crosshair; //объект для прицеливания из головы(лежит в паркнте камеры робота)
    private Vector3 targetPos; 
    


	// Use this for initialization
    void Start()
    {
        crosshair = GameObject.Find("aimfrom"); //находим перекрестие в мире
        
        rb = GetComponent<Rigidbody>();
        
        RaycastHit hit;
        
        if (Physics.Raycast(crosshair.transform.position, crosshair.transform.forward, out hit))
        {
            if (hit.collider.tag == "traningTarget")
            {
                Debug.Log("target" + hit.collider.gameObject);
                targetPos = hit.transform.position;
            }

            Debug.Log("target" + hit.collider.gameObject);
            targetPos = hit.point;
            Instantiate(locator, hit.point, Quaternion.identity);
            
        }
    }
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.forward * thrust);
        transform.LookAt(targetPos);
        Destroy(this.gameObject, 6);

        }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "traningTarget")
        {
            Debug.Log("KILLIT");

                Destroy(collision.gameObject);
            
            // Destroy(GetComponent<Collider>().gameObject);

        }
        Destroy(this.gameObject);
    }



}
