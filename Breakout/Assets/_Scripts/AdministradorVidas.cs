using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorVidas : MonoBehaviour
{
    [HideInInspector] public List<GameObject> vidas;
    public GameObject bolaPrefab;
    private Bola bolaScript;
    public GameObject MenuFinJuego;
    public Opciones opciones;

    void Start()
    {
        Transform[] hijos = GetComponentsInChildren<Transform>();
        foreach (Transform hijo in hijos) {
            vidas.Add(hijo.gameObject);
        }

        if (opciones.NivelDificultad == Opciones.dificultad.normal) {
            QuitarVidaDefauld();
        }
        if (opciones.NivelDificultad == Opciones.dificultad.dificil)
        {
            QuitarVidaDefauld(); QuitarVidaDefauld();
        }

    }

    public void EliminarVida() {
        var objetoAEliminar = vidas[vidas.Count - 1];
        Destroy(objetoAEliminar);
        vidas.RemoveAt(vidas.Count - 1);
        if (vidas.Count <= 0) {
            MenuFinJuego.SetActive(true);
            return;
        }
        var bola = Instantiate(bolaPrefab) as GameObject;
        bolaScript = bola.GetComponent<Bola>();
        bolaScript.BolaDestruida.AddListener(this.EliminarVida);
        Debug.Log($"Vidas restantes: {vidas.Count}");
    }

    private void QuitarVidaDefauld() {
        var objetoAEliminar = vidas[vidas.Count - 1];
        Destroy(objetoAEliminar);
        vidas.RemoveAt(vidas.Count - 1);
    }
}
