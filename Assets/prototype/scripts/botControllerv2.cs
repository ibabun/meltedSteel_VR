using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botControllerv2 : MonoBehaviour {

	// Use this for initialization
    public float initialAnimationSpeed = 0f; //Скорость анимации(походка для совпадения лап и земли)
    public float speedMult; //Множитель скорости для отладки
    private float speedMultMult; //реальная переменная которая используется в коде (либо speedMult либо 0)

    public GameObject botLegs; 
    public GameObject botHeadHorizontal;
    public GameObject botHeadVertical;
    public Transform leftGun;
    public Transform rightGun;

    private Animator botLegsA;
    public float translation = 0f;
	void Start () {
		botLegsA = botLegs.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        botLegsA.speed = speedMultMult;
        //animation
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

        //movingLegs =--------------------------------------------------------------------------------=
        translation = speedMultMult * initialAnimationSpeed; //корректируем скорость с походкой

        float Head_H = Input.GetAxis("Head_H")*1.5f;
        float Head_V = (Input.GetAxis("Head_V"))/3f;

        speedMultMult = 0f; //изначально скорость ровна нулю


            speedMultMult = speedMult;
            transform.Translate(0, 0, -Head_V);

            transform.Rotate(0, Head_H, 0);

            if (Input.GetKey("a")) //стрэйф влево
            {
                speedMultMult = speedMult;
                transform.Translate((-translation) * 5f, 0, 0);
            }

            if (Input.GetKey("d")) //стрэйф вправо
            {
                speedMultMult = speedMult;
                transform.Translate((translation) * 5f, 0, 0);
            }



        //movingHead =--------------------------------------------------------------------------------=

       // float Head_H = Input.GetAxis("Head_H");
       // botHeadHorizontal.transform.Rotate(0, Head_H, 0);
       // float Head_V = Input.GetAxis("Head_V");
       // botHeadVertical.transform.Rotate(-Head_V, 0, 0);

        //LegsToFace =--------------------------------------------------------------------------------=

        if (Input.GetKey(KeyCode.JoystickButton4))
        {
            legsToFaceF();
            Debug.Log("button4");
        }

	}

      void legsToFaceF ()
        {
          float rPlus = 2f;
          float rMinus = -2f;
            //while (this.transform.rotation.y != botHeadHorizontal.transform.rotation.y
          
         // if (this.transform.rotation.y >= botHeadHorizontal.transform.rotation.y)
         // {
         //     transform.Rotate(0, rMinus, 0); 
         // }
         // if (this.transform.rotation.y <= botHeadHorizontal.transform.rotation.y)
         // {
         //     transform.Rotate(0, rPlus, 0); 
         // }
         // Debug.Log("olololo");
        }

}

