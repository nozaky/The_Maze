using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//********************************************
//***SCRIPT CREADO POR DANIEL MONTERO LÓPEZ***
//********************************************
public class RecogedorObjetosLvl3 : MonoBehaviour {
    //variable contador
    private int cont;
    //variables de las puertas
    private GameObject puerta1,puerta2,puerta3,puerta4,puerta5,puerta6;
    public AudioClip takeOrion;
    private AudioSource sound;
	// Use this for initialization
	void Start () {
        cont = 0;
        sound = this.gameObject.GetComponent<AudioSource>();
        sound.clip = takeOrion;
	}
	
	// Update is called once per frame
	void Update () {
        //Destruimos las puertas según el número de oriones recogidos
        switch (cont)
        {
            case 1:
                puerta1 = GameObject.Find("Puerta1");
                Destroy(puerta1);
                break;
            case 3:
                for(int i = 1; i <= 2; i++)
                {
                    puerta2 = GameObject.Find("Puerta2");
                    Destroy(puerta2);
                }
                break;
            case 4:
                puerta3 = GameObject.Find("Puerta3");
                Destroy(puerta3);
                break;
            case 6:
                puerta4 = GameObject.Find("Puerta4");
                Destroy(puerta4);
                break;
            case 7:
                for (int i = 1; i <= 4; i++)
                {
                    puerta5 = GameObject.Find("Puerta5");
                    Destroy(puerta5);
                }
                break;
            case 9:
                for (int i = 1; i <= 2; i++)
                {
                    puerta6 = GameObject.Find("Puerta6");
                    Destroy(puerta6);
                }
                break;
        }
	}
    //Si chocamos con un Orion lo destruimos y sumamos en 1 el contador
    private void OnControllerColliderHit(ControllerColliderHit orion)
    {
        if (orion.gameObject.tag == "Orion")
        {
            Destroy(orion.gameObject);
            sound.Play();
            cont++;
        }
    }
}
