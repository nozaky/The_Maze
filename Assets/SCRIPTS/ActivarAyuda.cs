using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivarAyuda : MonoBehaviour {
    private int cont,tiempo, tiempoBloqueoAyuda,regreso;
    private float contAyuda, contBloqueoAyuda,reg;
    private Renderer orion,orion1, orion2, orion3, orion4, orion5, orion6;
	// Use this for initialization
	void Start () {
        regreso = 0;
        reg = 0;
        contBloqueoAyuda = 0;
        cont = 0;
        contAyuda = 0;
        orion = GameObject.Find("ayuda").GetComponent<Renderer>();
        orion1 = GameObject.Find("ayuda1").GetComponent<Renderer>();
        orion2 = GameObject.Find("ayuda2").GetComponent<Renderer>();
        orion3 = GameObject.Find("ayuda3").GetComponent<Renderer>();
        orion4 = GameObject.Find("ayuda4").GetComponent<Renderer>();
        orion5 = GameObject.Find("ayuda5").GetComponent<Renderer>();
        orion6 = GameObject.Find("ayuda6").GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        //tiempoAyuda();
        if (tiempo >= 10)
        {
            orion.enabled = false;
            orion1.enabled = false;
            orion2.enabled = false;
            orion3.enabled = false;
            orion4.enabled = false;
            orion5.enabled = false;
            orion6.enabled = false;
            contAyuda = 0;
            contBloqueoAyuda = 0;
            tiempo = 0;
            cont = -1;
        }
        if (cont == -1)
        {
            bloqueoAyuda();
        }
        if (tiempoBloqueoAyuda == 30)
        {
            cont = 0;
            tiempoBloqueoAyuda = 0;
            contBloqueoAyuda = 0;
        }
        //Al pulsar una vez se aumenta en 1 el contador
        if (Input.GetButtonDown("Jump") && (cont>=0) && (cont<3))
        {
            //Debug.Log(cont);
            cont += 1;
        }
        
        if (Input.GetButton("Jump"))
        {
            reg += Time.deltaTime;
            regreso = (int)reg;
            //Debug.Log(regreso);
            if (regreso >= 3)
            {
                //Debug.Log("Vuelvo al menú");
                SceneManager.LoadScene("Menu");
            }
        }
        if (Input.GetButtonUp("Jump"))
        {
            reg = 0;
            regreso = 0;
        }
        //Al llegar a 3, las ayudas se hacen visibles
        if (cont == 3)
        {
            orion.enabled = true;
            orion1.enabled = true;
            orion2.enabled = true;
            orion3.enabled = true;
            orion4.enabled = true;
            orion5.enabled = true;
            orion6.enabled = true;
            //tiempo que la ayuda está visible
            tiempoAyuda();
        }
    }
    private void tiempoAyuda()
    {
        contAyuda += Time.deltaTime;
        tiempo = (int)contAyuda;
        Debug.Log(tiempo);
    }
    private void bloqueoAyuda()
    {
        contBloqueoAyuda += Time.deltaTime;
        tiempoBloqueoAyuda = (int)contBloqueoAyuda;
        //Debug.Log(tiempoBloqueoAyuda);
    }
}
