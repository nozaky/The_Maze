using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportar : MonoBehaviour {
    private string nombre;
    private GameObject personaje,tpObjeto;
    private float posX, posY, posZ;
	// Use this for initialization
	void Start () {
        nombre = this.name;
        personaje = GameObject.FindWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        switch (nombre)
        {
            case "TP1A":
                tpObjeto = GameObject.Find("TP1B");
                posX = tpObjeto.transform.position.x;
                posY = -28;
                posZ = tpObjeto.transform.position.z;
                personaje.transform.position = new Vector3(75,-28,0);
                break;
            case "TP1B":
                personaje.transform.position = new Vector3(5,1.5f,0);
                break;
            case "TP2A":
                personaje.transform.position = new Vector3(45,-28,-20);
                break;
            case "TP2B":
                personaje.transform.position = new Vector3(30,1.5f,-20);
                break;
            case "TP3A":
                personaje.transform.position = new Vector3(65,-28, -40);
                break;
            case "TP3B":
                personaje.transform.position = new Vector3(10, 1.5f, -40);
                break;
            case "TP4A":
                personaje.transform.position = new Vector3(45,-28, -30);
                break;
            case "TP4B":
                personaje.transform.position = new Vector3(35, 1.5f, -30);
                break;
            case "TP5A":
                personaje.transform.position = new Vector3(15,-28, -40);
                break;
            case "TP5B":
                personaje.transform.position = new Vector3(60, 1.5f, -40);
                break;
            case "TP6A":
                personaje.transform.position = new Vector3(15,-28, -20);
                break;
            case "TP6B":
                personaje.transform.position = new Vector3(65, 1.5f, -10);
                break;
            case "TP7A":
                personaje.transform.position = new Vector3(-5,-28, 10);
                break;
            case "TP7B":
                personaje.transform.position = new Vector3(80, 1.5f, 10);
                break;
            case "TP8A":
                personaje.transform.position = new Vector3(25,-28, -30);
                break;
            case "TP8B":
                personaje.transform.position = new Vector3(55, 1.5f, -30);
                break;
            case "TP9A":
                personaje.transform.position = new Vector3(-5,-28, -60);
                break;
            case "TP9B":
                personaje.transform.position = new Vector3(80, 1.5f, -60);
                break;
            case "TP10A":
                personaje.transform.position = new Vector3(35, -28, -60);
                break;
            case "TP10B":
                tpObjeto = GameObject.Find("TP10A");
                posX = tpObjeto.transform.position.x;
                posY = 1.5f;
                posZ = tpObjeto.transform.position.z;
                personaje.transform.position = new Vector3(posX, posY, posZ);
                break;
            default:
                Debug.Log("SE HA PRODUCIDO UN ERROR");
                break;
        }
    }
}
