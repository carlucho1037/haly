using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPoints : MonoBehaviour
{

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {

            Debug.Log("entro toco el objeto");
            Inventory.singleton.AddInventory(1);
				
            Destroy(gameObject);
		   
        }
		
		Debug.Log ("no toco el objeto");
    }
}