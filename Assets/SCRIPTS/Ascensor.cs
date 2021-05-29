using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//********************************************
//***SCRIPT CREADO POR DANIEL MONTERO LÓPEZ***
//********************************************
public class Ascensor : MonoBehaviour {

    private int nivel;
    private Animation anim;
    private Collider bloqueador;
	// Use this for initialization
	void Start () {
        nivel = 0;
        anim = GetComponent<Animation>();
        bloqueador = GameObject.Find("bloqueador").GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () {
        //nivel donde se encuentra la plataforma elevadora
        if (transform.position.y == -0.25)
        {
            nivel = 1;
        }
        if (transform.position.y == 49.75)
        {
            nivel = 2;
        }
    }
    //Metodo al entrar en contacto con el trigger
    private void OnTriggerEnter(Collider personaje)
    {
        //activación de la animación si entra en contacto con el personaje
        if(personaje.tag == "Player")
        {
            if (nivel == 1)
            {
                anim.Play("AscensorSubir");
                bloqueador.isTrigger = false;
            }
            if (nivel == 2)
            {
                anim.Play("AscensorBajar");
                bloqueador.isTrigger = true;
            }
        }
        
    }

}
