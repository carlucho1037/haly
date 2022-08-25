using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class DetectarEnemigo : MonoBehaviour
{
    public Transform enemigo;
    public Transform player;
    public float velocidad;

    private bool activo;
    private Vector3 playerPosicion;

    public NavMeshAgent agente;


    private void Update()
    {
        playerPosicion = new Vector3(player.position.x, enemigo.position.y, player.position.z);

        if (activo == true)
        {
            //enemigo.transform.position = Vector3.MoveTowards(transform.position, playerPosicion, velocidad * Time.deltaTime);
            //enemigo.transform.LookAt(playerPosicion);

            agente.SetDestination(playerPosicion);
            Debug.Log("agente");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "personaje")
        {
            activo = true;
            Debug.Log("hola");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "personaje")
        {
            activo = false;
        }
    }

}
