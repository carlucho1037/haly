using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorController : MonoBehaviour
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
			anim.SetBool("salte", true);
		}else{
			
			anim.SetBool("salte", false);
		}
        
		
    }
}
