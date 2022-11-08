using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Inverso : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        reboteInverso = true;
    }

    // Update is called once per frame
    void Update()
    {
        base.RebotarBola();
    }
}
