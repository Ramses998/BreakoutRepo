using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] public int limiteX = 23;
    [SerializeField] public float VelocidadPaddle = 2f;

    Transform transform;

    Vector3 mousePos2D;Vector3 mousePos3D;

    // Start is called before the first frame update
    void Start()
    {
        transform = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //mousePos2D = Input.mousePosition;
        //mousePos2D.z = -Camera.main.transform.position.z;
        //mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        /*
        if (Input.GetKey(KeyCode.RightArrow)) {
            this.transform.Translate(Vector3.down * VelocidadPaddle * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            this.transform.Translate(Vector3.up * VelocidadPaddle * Time.deltaTime);
        }
        */

        this.transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * VelocidadPaddle * Time.deltaTime);

        Vector3 pos = this.transform.position;
        //pos.x = mousePos3D.x;

        if (pos.x < -limiteX) {
            pos.x = -limiteX;
        } else if (pos.x > limiteX)
        {
            pos.x = limiteX;
        }

        this.transform.position = pos;
    }
}
