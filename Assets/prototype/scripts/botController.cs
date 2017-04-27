using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botController : MonoBehaviour {

	// Use this for initialization

    public bool inTheAir = false;
    public bool readyToJump = true;
    public float jumpPower = 10f;
    public Rigidbody rb;
    public float initialAnimationSpeed = 0f; //Скорость анимации(походка для совпадения лап и земли)
    public GameObject projectileGUN; //отладочные пули
    public GameObject projectile; //РАКЕТЫ!!!!
    public GameObject botLegs; 
    public GameObject botHeadHorizontal;
    public GameObject botHeadVertical;
    public Transform leftGun;
    public Transform rightGun;
    public Transform rocketLouncher;
    public Transform LookAt_target;
    private Animator botLegsA;
    public float translation = 0f;
    public bool spwned = false;

    public AudioSource walk;


    void Start ()
    {
        botLegsA = botLegs.GetComponent<Animator>();
        StartCoroutine(waitForSpawn());
        rb = GetComponent<Rigidbody>();
        //botLegsA.speed = 2;

	}

    IEnumerator waitForSpawn()
    {
        yield return new WaitForSeconds(3.2f);
        botLegsA.SetBool("SPAWN", true);
        spwned = true;
        rb.useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
    }




    //void for detecting the floor AND JUMPING ALLOW!!!!!        
    //vars: inTheAir | readyToJump |

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "staticCollider")
        {
            readyToJump = true;
            inTheAir = false;
            Debug.Log("rdy2Jump");
        }
    }



	// Update is called once per frame
	void Update () {
        if (readyToJump)  
        {
        transform.LookAt(LookAt_target); //<----------------------- постоянно легтуфэйс
        }

        //botLegsA.speed = speedMultMult;
        //animation на кнопках
        bool walkZ = Input.GetKey("w");
        botLegsA.SetBool("walkingZ", walkZ);

        bool walkZm = Input.GetKey("z");
        botLegsA.SetBool("walkingZm", walkZm);

        bool walkL = Input.GetKey("a");
        botLegsA.SetBool("walkingL", walkL);

        bool walkR = Input.GetKey("d");
        botLegsA.SetBool("walkingR", walkR);

        bool jump = Input.GetKey("space");
        botLegsA.SetBool("fly", jump);


        if (spwned)
        {
            //контроль джостиком --------------------------------------------------------------

            float Chass_Z = Input.GetAxis("Chassis_Z");
            float Chass_X = Input.GetAxis("Chassis_X") / 3; //strafe

            float Head_V = Input.GetAxis("Head_V") / 1.5f;
            transform.Translate(Chass_X, 0, -Head_V);



            //movingHead =--------------------------------------------------------------------------------=

            float Head_H = Input.GetAxis("Head_H") * 1.5f;
            botHeadHorizontal.transform.Rotate(0, Head_H, 0);


            //контроль джостиком ------------------------АНИМАЦИЯ--------------------------------------
            if (Head_V < 0f) //идём вперёд
            {
                walkZ = true;
                botLegsA.speed = Mathf.Abs(Head_V) * initialAnimationSpeed;
                botLegsA.SetBool("walkingZ", walkZ);
            }

            if (Head_V > 0f) //идём назад
            {
                walkZm = true;
                botLegsA.speed = Head_V * initialAnimationSpeed;
                botLegsA.SetBool("walkingZm", walkZm);
            }


            //Jumping like a rabbit =--------------------------------------------------------------------------------=
            //vars: inTheAir | readyToJump | jumpPower
            if (Chass_Z >= 0.9f && readyToJump)
            {
                rb.AddForce(0, jumpPower, 0);
                inTheAir = true;
                readyToJump = false;
                Debug.Log(Chass_Z);
            }

            if (Chass_Z <= -0.9f && readyToJump)
            {
                rb.AddForce(0, jumpPower, 0);
                inTheAir = true;
                readyToJump = false;
                Debug.Log(Chass_Z);
            }


            //LegsToFace =--------------------------------------------------------------------------------=

            if (Input.GetKey(KeyCode.JoystickButton4) && readyToJump)
            {

                rb.AddForce(0, jumpPower, 0);
                inTheAir = true;
                readyToJump = false;
                Debug.Log(Chass_Z);

                //legsToFaceF();
                Debug.Log("button4");
            }

            //ФАЕР! ФАЯФАЯ! =--------------------------------------------------------wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww------------------------=

            //стреляй пушки

            if (Input.GetKey(KeyCode.JoystickButton14))
            {
                //Debug.Log("button0");
                Instantiate(projectileGUN, leftGun.position, leftGun.rotation);
                Instantiate(projectileGUN, rightGun.position, rightGun.rotation);

            }


            //стреляй РАКЕТА!!!!!!



            if (Input.GetKeyDown(KeyCode.JoystickButton1))
            {
                Instantiate(projectile, rocketLouncher.position, rocketLouncher.rotation);

            }

        }


	}

      void legsToFaceF ()
        {
         // float rPlus = 2f;
         // float rMinus = -2f;
          
        //  if (this.transform.rotation.y >= botHeadHorizontal.transform.rotation.y)
      //    {
    //          transform.Rotate(0, rMinus, 0); 
 ///         }

         // if (this.transform.rotation.y <= botHeadHorizontal.transform.rotation.y)
         // {
         //     transform.Rotate(0, rPlus, 0); 
        //  }

            transform.LookAt(LookAt_target);
          Debug.Log("olololo");
        }

}

