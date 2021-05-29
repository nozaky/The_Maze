using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//********************************************
//***SCRIPT CREADO POR DANIEL MONTERO LÓPEZ***
//********************************************
public class ContadorOriones : MonoBehaviour {

    public int cont;
    private GameObject orion,muro,luz;
    private string nombre;
    private int id;
    private Collider bloqueoCollider,continuarCollider;
    private Renderer bloqueoRenderer,continuarRenderer;
    private AudioSource sonidos;
    public AudioClip cogerOrion;
    // Use this for initialization
    void Start () {
        cont = 0;
        sonidos = this.gameObject.GetComponent<AudioSource>();
        //orion = GameObject.Find ("Sphere");
        bloqueoCollider = GameObject.Find("Bloqueo").GetComponent<Collider>();
        continuarCollider = GameObject.Find("Continuar").GetComponent<Collider>();
        bloqueoRenderer = GameObject.Find("Bloqueo").GetComponent<Renderer>();
        continuarRenderer = GameObject.Find("Continuar").GetComponent<Renderer>();
        // P.isTrigger = true;
        bloqueoCollider.isTrigger = true;
        continuarCollider.isTrigger = false;
        bloqueoRenderer.enabled = false;
        continuarRenderer.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (cont==5)
        {
            continuarRenderer.enabled = false;
            continuarCollider.isTrigger = true;
        }
        if (bloqueoCollider.isTrigger==false)
        {
            //destruir los muros del laberinto (primera parte del laberinto)
            for (int i = 1; i < 120; i++)
            {
                id = i;
                string texto = "Lb (" + id.ToString() + ")";
                muro = GameObject.Find(texto);
                Destroy(muro);
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Continuar")
        {
            bloqueoCollider.isTrigger = false;
            bloqueoRenderer.enabled = true;
        }
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        sonidos.clip = cogerOrion;
        if (hit.gameObject.tag == "Orion")
        {
            cont++;
            sonidos.Play();
            Destroy(hit.gameObject);
        }
    }
}
