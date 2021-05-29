using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//********************************************
//***SCRIPT CREADO POR DANIEL MONTERO LÓPEZ***
//********************************************
public class CrearPlano2 : MonoBehaviour {
    public GameObject plane;
    private int posX, posY, posZ;
    private int posX2, posY2, posZ2;
	// Use this for initialization
	void Start () {
        //Variables para el suelo de la primera parte
        posX = -40;
        posY = 0;
        posZ = -11;

        //Variables para el suelo de la segunda parte
        posX2 = posX;
        posY2 = posY;
        posZ2 = 79;
        //Bucle para el suelo de la primera parte
        for (int i = 1; i<=45;i++)
        {
            Instantiate(plane, new Vector3(posX, posY, posZ), Quaternion.identity);
            posX = posX + 10;
            //cambio de linea para realizar un cuadrado
            if (i%9==0)
            {
                posZ = posZ + 10;
                posX = - 40;
            }
        }
        //Bucle para el suelo de la segunda parte
        for (int i = 1; i<=45;i++)
        {
            Instantiate(plane, new Vector3(posX2, posY2, posZ2), Quaternion.identity);
            posX2 = posX2 + 10;
            //cambio de linea para realizar un cuadrado
            if (i % 9 == 0)
            {
                posZ2 = posZ2 + 10;
                posX2 = -40;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
