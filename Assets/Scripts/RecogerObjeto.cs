using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerObjeto : MonoBehaviour
{




    public GameObject handPoint;

    private GameObject pickedObject = null;



    void Update()
    {

        if (pickedObject != null)
        {
            if (Input.GetKey("e"))
            {
                pickedObject.GetComponent<Rigidbody>().isKinematic = true;
                pickedObject.GetComponent<Rigidbody>().useGravity = false;

                pickedObject.gameObject.transform.SetParent(null);
                pickedObject = null;
            }
        }
    }



    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("objeto"))
        {
            if (Input.GetKey("r") && pickedObject == null)
            {
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;

                other.transform.position = handPoint.transform.position;
                other.gameObject.transform.SetParent(handPoint.gameObject.transform);

                pickedObject = other.gameObject;
            }
        }
    }



}
