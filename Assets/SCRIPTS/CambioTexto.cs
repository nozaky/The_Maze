using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//********************************************
//***SCRIPT CREADO POR DANIEL MONTERO LÓPEZ***
//********************************************
public class CambioTexto : MonoBehaviour {
    private TextMesh texto;
    private float tiempo;
    private string textoNivel;
    // Use this for initialization
	void Start () {
       
        texto = GameObject.Find("Texto1").GetComponent<TextMesh>();
        tiempo = 0;
        textoNivel = "NIVEL 1";
    }
	
	// Update is called once per frame
	void Update () {
        tiempo += Time.deltaTime;
	}
    private void OnTriggerEnter(Collider other)
    {
        tiempo = 0;
    }
    private void OnTriggerStay(Collider personaje)
    {
        if (personaje.gameObject.tag == "Player")
        {
            int time = (int)tiempo;
            texto.text = time.ToString();
        }
        if (tiempo>4)
        {
            textoNivel = "NIVEL\nDESBLOQUEADO";
            texto.text = textoNivel;
        }
    }
    private void OnTriggerExit(Collider personaje)
    {
        if (personaje.gameObject.tag == "Player")
        {
            texto.text = textoNivel;
            tiempo = 0;
        }
            
    }
}
