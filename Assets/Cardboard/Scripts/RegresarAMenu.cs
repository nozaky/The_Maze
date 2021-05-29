using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RegresarAMenu : MonoBehaviour {
    private int regreso;
    private float reg;
	// Use this for initialization
	void Start () {
        reg = 0;
        regreso = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump"))
        {
            reg += Time.deltaTime;
            regreso = (int)reg;
            // Debug.Log(regreso);
            if (regreso >= 3)
            {
                //Debug.Log("Vuelvo al menú");
                SceneManager.LoadScene("Menu");
            }
        }
        if (Input.GetButtonUp("Jump"))
        {
            reg = 0;
            regreso = 0;
        }
    }
}
