using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Playermove : MonoBehaviour
//{

//    public float  runSpeed = 7;
//    public float  rotationSpeed = 250;

//    public Animator animator;

//    private float x,y;

//    void Update()
//    {
//        x= Input.GetAxis("Horizontal");
//        y= Input.GetAxis("Vertical");

//        transform.Rotate(0, x*Time.deltaTime*rotationSpeed,0);

//        transform.Translate(0, 0, y*Time.deltaTime*runSpeed);


//        animator.SetFloat("VelX", x);
//        animator.SetFloat("VelY", y);

//    }
//}




public class Playermove : MonoBehaviour
{

    public float runSpeed = 5.0f;
    public float rotationSpeed = -10.0f;

    public Animator animator;
    private float x, y;

    public Rigidbody rb;
    public float fuerzaDeSalto = 8f;
    public bool puedoSaltar;


    public bool estoyAtacando;
    public bool avanzoSolo;
    public float impulsoDeGolpe = 10f;

    void Start()
    {
        puedoSaltar = false;
        animator = GetComponent<Animator>();
    }


    void FixedUpdate()
    {

        if (!estoyAtacando)
        {
            transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
            transform.Translate(0, 0, y * Time.deltaTime * runSpeed);
        }

       

        if (avanzoSolo)
        {
            rb.velocity = transform.forward * impulsoDeGolpe;
        }

    }



    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
           

        if(Input.GetKeyDown(KeyCode.Return) && puedoSaltar && !estoyAtacando)
        {
            animator.SetTrigger("golpeo");
            estoyAtacando = true;
        }


        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);


        if (puedoSaltar)
        {

            if (!estoyAtacando)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    animator.SetBool("salte", true);
                    rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
                }
            }

         
            animator.SetBool("tocosuelo", true);
        }
        else
        {
            EstoyCayendo();
        }

    }

    public void EstoyCayendo()
    {
        animator.SetBool("tocosuelo", false);
        animator.SetBool("salte", false);
    }



    public void DejeDeGolpear ()
    {
        estoyAtacando = false;
       // avanzoSolo = false;
    }

    public void AnanzoSolo()
    {
        avanzoSolo = true;
    }

    public void DejoDeAvanzar()
    {
        avanzoSolo = false;
    }

}
