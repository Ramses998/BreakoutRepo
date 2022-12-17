using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    public int resistencia = 1;
    public UnityEvent AumentarPuntaje;
    public bool invulnerable = false;
    public bool reboteInverso = false;
    public Opciones opciones;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola") {
            RebotarBola(collision);
        }
    }

    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        resistencia--;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0 && !invulnerable) {
            AumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }
    }

    public virtual void RebotarBola() {

        if (reboteInverso) //Si está activado, no se agregará 90 grados a la dirección de rebote. Regresará por donde impactó.
        {

        }
        else {

        }
    }
}