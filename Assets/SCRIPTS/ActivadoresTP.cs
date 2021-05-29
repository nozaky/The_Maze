using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadoresTP : MonoBehaviour {
    private Collider tp;
    private string transportador;
	// Use this for initialization
	void Start () {
        for (int i = 1; i<=10; i++)
        {
            transportador = "TP" + i.ToString() + "A";
            tp = GameObject.Find(transportador).GetComponent<Collider>();
            tp.enabled = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        //Activar triggers del nivel superior
        for (int i = 1; i <= 10; i++)
        {
            transportador = "TP" + i.ToString() + "A";
            tp = GameObject.Find(transportador).GetComponent<Collider>();
            tp.enabled = true;
        }
        //Activar triggers del nivel superior TPNA
        for (int i = 1; i <= 13; i++)
        {
            transportador = "TPNA" + i.ToString();
            tp = GameObject.Find(transportador).GetComponent<Collider>();
            tp.enabled = true;
        }



        //Desactivar triggers del nivel inferior
        for (int i = 1; i <= 10; i++)
        {
            transportador = "TP" + i.ToString() + "B";
            tp = GameObject.Find(transportador).GetComponent<Collider>();
            tp.enabled = false;
        }
        //Desactivar triggers del nivel inferior TPNB
        for (int i = 1; i <= 13; i++)
        {
            transportador = "TPNB" + i.ToString();
            tp = GameObject.Find(transportador).GetComponent<Collider>();
            tp.enabled = false;
        }
    }
}
