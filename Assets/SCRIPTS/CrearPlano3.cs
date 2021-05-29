using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPlano3 : MonoBehaviour {
    //objeto prefab del plano inferior
    public GameObject plano;
    //variables del plano inferior
    private int posX, posY, posZ;
    //variables del plano superior izquierdo
    private int posZI;
    private float posXI;
    //variables del plano superior derecho
    private int posXD;
    private float posZD;
    //variable de la altura estatica
    private static int posYStatic;
	// Use this for initialization
	void Start () {
        //variables del plano inferior
        posX = 0;
        posY = 0;
        posZ = -15;
        //variables del plano superior izquierdo
        posXI = -9.5f;
        posZI = -15;
        posYStatic = 50;
        //variables del plano superior derecho
        posXD = 55;
        posZD = 49.5f;
        //Bucle para crear plano del mapa inferior
        for (int i = 1;i <= 49; i++)
        {
            Instantiate(plano, new Vector3(posX,posY,posZ),Quaternion.identity);
            posX = posX + 10;
            if (i%7==0)
            {
                posX = 0;
                posZ = posZ + 10;
            }
        }
        //Bucle pra crear plano del mapa superior izquierdo
        for (int i = 1; i<= 40; i++)
        {
            Instantiate(plano, new Vector3(posXI, posYStatic, posZI), Quaternion.identity);
            posXI = posXI - 10;
            if (i%4==0)
            {
                posZI = posZI + 10;
                posXI = -9.5f;
            }
        }
        //Bucle pra crear plano del mapa superior derecho
        for (int i = 1; i<= 28; i++)
        {
            Instantiate(plano, new Vector3(posXD, posYStatic, posZD), Quaternion.identity);
            posXD = posXD - 10;
            if (i % 7 == 0)
            {
                posXD = 55;
                posZD = posZD + 10;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
