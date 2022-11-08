using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    public int resistencia = 1;
    public bool invulnerable = false;
    public bool reboteInverso = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0 && !invulnerable) {
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