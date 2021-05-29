using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//********************************************
//***SCRIPT CREADO POR DANIEL MONTERO LÓPEZ***
//********************************************

public class ActivarAnimacion : MonoBehaviour {
    //Declaramos las variables y los objetos
    private int cont;
    private Animator open1;
    private GameObject openGO1,openGO2,openGO3,muro;
    private Collider caminoBloqueoCollider;
    private Renderer caminoBloqueoRenderer;
    private Transform pos;
    public GameObject puente,camino;
    private int posZ;
    private GameObject puntoFinal;
    public AudioClip takeOrion;
    private AudioSource sound;
	// Use this for initialization
	void Start () {
        posZ = 39;
        cont = 0;
        sound = this.gameObject.GetComponent<AudioSource>();
        open1 = GameObject.Find("Puerta").GetComponent<Animator>();
        caminoBloqueoCollider = GameObject.Find("caminoBloqueo").GetComponent<Collider>();
        caminoBloqueoRenderer = GameObject.Find("caminoBloqueo").GetComponent<Renderer>();
        openGO3 = GameObject.Find("Puerta3");
        openGO2 = GameObject.Find("Puerta2");
        openGO1 = GameObject.Find("Puerta");
        puntoFinal = GameObject.Find("FINAL");
        open1.enabled = false;
        //Desactivamos el muro del camino final hasta obtener los 9 oriones
        caminoBloqueoCollider.isTrigger = true;
        caminoBloqueoRenderer.enabled = false;
        sound.clip = takeOrion;
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    //al entrar en contacto con el collider del objeto Activacion se activa la animacion de apertura y se destruye el objeto al segundo
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Activacion")
        {
        //    charapter.transform.Translate(new Vector3(0,0,20));
            if (cont == 2)
            {
                //se activa la animacion
                open1.enabled = true;
                //se destruye el objeto al segundo de ser llamado
                Destroy(openGO1, 1f);
            }
        }
    }
    //al chocar con el objeto se suma el contador en uno y se destruye el objeto
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //variables de posición local
        int x, y;
        float z;
        x = -5;
        y = 4;
        z = 114.5f;

        if (hit.gameObject.tag == "Orion")
        {
            //sumamos contador en uno
            cont++;
            sound.Play();
            if (cont>0 && cont<5)
            {
                Instantiate(puente, new Vector3(0, -0.5f, posZ), Quaternion.identity);
                posZ = posZ + 10;
            }
            if (cont == 8)
            {
                //Destruir el muro que da paso al último orión
                Destroy(openGO3);
            }            
            if (cont == 9)
            {
                //destruir los muros del laberinto 
                for (int i = 1; i <= 121; i++)
                {
                    string texto = "Cube (" + i.ToString() + ")";
                    muro = GameObject.Find(texto);
                    Destroy(muro);
                }
                //Crear muros para el camino en linea recta hacia el portal
                for (int i = 1; i <= 8; i++)
                {
                    if (i == 5)
                    {
                        x = x * (-1);
                        z = 114;
                    }
                    Instantiate(camino, new Vector3(x, y, z), camino.transform.rotation);
                    z = z - 21;
                }
                //Activamos el muro límite
                caminoBloqueoCollider.isTrigger = false;
                caminoBloqueoRenderer.enabled = true;
                //Subimos el punto final
                puntoFinal.transform.position = new Vector3(0,2,45);
            }
            //destruimos el objeto
            Destroy(hit.gameObject);
            //cuando consigamos los cuatro oriones se ejecutara la siguiente condicion
            if (cont == 4)
            {
                //se destruye el objeto
                Destroy(openGO2);
            }
        }
    }
}
