using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atacar : MonoBehaviour
{

    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("x"))
        {
            anim.SetBool("golpeo", true);
            estoyAtacando = true;
        }
        else
        {

            anim.SetBool("golpeo", false);
            estoyAtacando = false;
        }


    }

    public bool estoyAtacando;
	public bool avanzoSolo;
	public float implusoDe1golpe =10f;

    public void DejeDeGolpear()
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
