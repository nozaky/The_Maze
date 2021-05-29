using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPlano4 : MonoBehaviour {
    public GameObject plane, roof;
    private int posX, posZ;
    private float posY;
    // Use this for initialization
    void Start () {
        //Inicializacion de variables de posición
        posX = -5;
        posY = 0;
        posZ = 10;
        //Bucle para crear Plano superior
		for(int i = 1; i <= 90; i++)
        {
            Instantiate(plane,new Vector3(posX,posY,posZ),Quaternion.identity);
            posX = posX + 10;
            if (i%10==0)
            {
                posX = -5;
                posZ = posZ - 10;
            }
        }
        //Bucle para crear Plano inferior
        posX = -5;
        posY = -30;
        posZ = 10;
        for (int i = 1; i <= 90; i++)
        {
            Instantiate(plane, new Vector3(posX, posY, posZ), Quaternion.identity);
            posX = posX + 10;
            if (i % 10 == 0)
            {
                posX = -5;
                posZ = posZ - 10;
            }
        }
        //Bucle para crear techo inferior
        posX = -5;
        posY = -21.5f;
        posZ = 10;
        for (int i = 1; i <= 90; i++)
        {
            Instantiate(roof, new Vector3(posX, posY, posZ), Quaternion.identity);
            posX = posX + 10;
            if (i % 10 == 0)
            {
                posX = -5;
                posZ = posZ - 10;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
