using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosEnemigo : MonoBehaviour
{
    public GameObject enemigoMesh;
    public float damage;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            Debug.Log(damage + "De Daño al Player");
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<CapsuleCollider>().enabled=false;
            enemigoMesh.SetActive(false);
            Destroy(gameObject, 0.6f);

        }
    }
}
