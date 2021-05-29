using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPlanoMenu : MonoBehaviour {
    public GameObject suelo;
    public GameObject sueloNivel1,sueloNivel2,sueloNivel3,sueloNivel4;
    private float posX, posY, posZ;
	// Use this for initialization
	void Start () {
        //Suelo general
        posX = 35f;
        posY = 0f;
        posZ = -10f;
        for (int i = 1; i <= 49; i++)
        {
            Instantiate(suelo, new Vector3(posX, posY, posZ), Quaternion.identity);
            posZ = posZ + 10;
            if (i % 7 == 0)
            {
                posX = posX - 10;
                posZ = -10;
            }
        }
        //Suelo del primer nivel
        posX = -14.5f;
        posY = 0.01f;
        posZ = -9f;
        for (int i=1;i<=4;i++)
        {
            Instantiate(sueloNivel1,new Vector3(posX,posY,posZ),Quaternion.identity);
            posZ = posZ + 10;
            if (i%2==0)
            {
                posX = posX - 10;
                posZ = -9;
            }
        }
        //Suelo del Segundo nivel
        posX = -14.5f;
        posY = 0.01f;
        posZ = 12f;
        for (int i = 1; i <= 4; i++)
        {
            Instantiate(sueloNivel2, new Vector3(posX, posY, posZ), Quaternion.identity);
            posZ = posZ + 10;
            if (i % 2 == 0)
            {
                posX = posX - 10;
                posZ = 12;
            }
        } 
        //Suelo del Tercer nivel
        posX = 28f;
        posY = 0.01f;
        posZ = 12f;
        for (int i = 1; i <= 4; i++)
        {
            Instantiate(sueloNivel3, new Vector3(posX, posY, posZ), Quaternion.identity);
            posZ = posZ + 10;
            if (i % 2 == 0)
            {
                posX = posX - 10;
                posZ = 12;
            }
        }
        //Suelo del Cuarto nivel
        posX = 28f;
        posY = 0.01f;
        posZ = -9f;
        for (int i = 1; i <= 4; i++)
        {
            Instantiate(sueloNivel4, new Vector3(posX, posY, posZ), Quaternion.identity);
            posZ = posZ + 10;
            if (i % 2 == 0)
            {
                posX = posX - 10;
                posZ = -9;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
