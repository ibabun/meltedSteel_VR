using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wpGliderControls : MonoBehaviour {
    public GameObject testPref;
    public Transform gunObj;
    public Rigidbody rb;
    public float force = 2;
    public float hoverDist = 8.0f;
    public float damping = 1.0f;
    public Transform restart;
    public float Mult = 1.0f;
    public float tParam = 0.5f;
    static float t = 0.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        t += 0.1f * Time.deltaTime;
        Mult = Mathf.Lerp(1, 3, t);
        Debug.Log(Mult);
        if (Input.GetKey(KeyCode.JoystickButton4))
        {
            this.transform.position = restart.position;
            this.transform.rotation = restart.rotation;

            t = 0;
        }


         RaycastHit hit;
            Ray ray = new Ray(this.transform.position, -this.transform.up);
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 incomingVec = hit.point - gunObj.position;
                Vector3 reflectVec = Vector3.Reflect(incomingVec, hit.normal);
                Debug.DrawLine(gunObj.position, hit.point, Color.red);
                Debug.DrawRay(hit.point, reflectVec, Color.green);

                Quaternion rot = Quaternion.FromToRotation(Vector3.up, hit.normal);

                if (hit.collider.tag == "track")
                {
                    Physics.gravity = -(hit.normal * 100);
                  //  Debug.Log(hit.normal);
                }
               // if (hoverDist < hit.distance)
               // {
               // rb.AddForce(hit.normal * force);
               // }
                    //Debug.Log(hit.point);
            }
            

            


        ////////gravityAlteration




        //контроль джостиком ------------

        float Chass_Z = Input.GetAxis("Chassis_Z");//*10;
        float Chass_X = Input.GetAxis("Chassis_X");//*10;

        float Head_V = Input.GetAxis("Head_V") * Mult;
        transform.Translate(Chass_X, 0, -Head_V);

        //movingHead =--------------------------------------------------------------------------------=

        float Head_H = Input.GetAxis("Head_H") * 1.5f;
        transform.Rotate(0, Head_H, 0);

    }

    //void OnCollisionStay(Collision collision)
   // {
    //    ContactPoint contact = collision.contacts[0];
    //    Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
    //    Vector3 pos = contact.point;
    //    if (collision.collider.tag == "track")
    //    {
    //        Physics.gravity = -(contact.normal * 100);
    //        Debug.Log(contact.normal);
    //    }
       // Instantiate(testPref, pos, rot);
        //Destroy(gameObject);
  // }



}