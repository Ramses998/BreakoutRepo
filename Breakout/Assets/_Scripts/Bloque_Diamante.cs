using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Diamante : Bloque
{

    // Start is called before the first frame update
    void Start()
    {
        invulnerable = true;
    }

    // Update is called once per frame
    void Update()
    {
        base.RebotarBola();
    }
}
