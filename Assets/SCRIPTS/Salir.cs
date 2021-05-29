using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour {

    private int cont = 0;
    private float seg;
    // Use this for initialization
    void Start () {
        seg = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Jump"))
        {
            cont += 1;
            seg = 0;
        }
        if (Input.GetButton("Jump")&&(cont>=2))
        {
            contador();
        }
	}
    private void contador()
    {
        seg += Time.deltaTime;
        //Debug.Log(seg);
        int tiempo = (int)seg;
        if (tiempo==3)
        {
            //Debug.Log("Ha llegado a 3 seg");
            Application.Quit();
        }
    }
}
