using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarParticulas : MonoBehaviour
{

    [Header("Particulas Aura")]
        public ParticleSystem particulasAura;


    [Header("Ataque")]
    public ParticleSystem particulasAtaque;
    public ParticleSystem particulasMano;


    public void ActivarAura()
    {
        particulasAura.Play();
    }

    public void ActivarAtaque()
    {
        particulasAtaque.Play();
    }


    public void ActivarMano()
    {
        particulasMano.Play();
    }

}
