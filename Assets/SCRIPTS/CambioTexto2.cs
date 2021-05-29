using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioTexto2 : MonoBehaviour {
    private TextMesh texto;
    private float tiempo;
    private string textoNivel;
    // Use this for initialization
    void Start()
    {
        texto = GameObject.Find("Texto2").GetComponent<TextMesh>();
        tiempo = 0;
        textoNivel = "NIVEL 2";
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
            if(VariablesGlobales.cont >= 1)
            {
                textoNivel = "NIVEL\nDESBLOQUEADO";
                texto.text = textoNivel;
            }
            else
            {
                textoNivel = "Nivel 1 no superado\n(NIVEL 2)";
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
