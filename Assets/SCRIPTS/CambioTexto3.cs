using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioTexto3 : MonoBehaviour {
    private TextMesh texto;
    private float tiempo;
    private string textoNivel;
    // Use this for initialization
    void Start()
    {
        texto = GameObject.Find("Texto3").GetComponent<TextMesh>();
        tiempo = 0;
        textoNivel = "NIVEL 3";
    }
    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        tiempo = 0;
    }
    private void OnTriggerStay(Collider personaje)
    {
        int time = (int)tiempo;
        texto.text = time.ToString();

        if (tiempo > 4)
        {
            
            if (VariablesGlobales.cont >= 2)
            {
                textoNivel = "NIVEL\nDESBLOQUEADO";
                texto.text = textoNivel;
            }
            else
            {
                textoNivel = "Nivel 2 no superado\n(NIVEL 3)";
                texto.text = textoNivel;
            }
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
