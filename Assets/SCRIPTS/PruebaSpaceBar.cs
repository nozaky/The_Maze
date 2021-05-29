using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaSpaceBar : MonoBehaviour {
    private float i;
	// Use this for initialization
	void Start () {
        i = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Se pulsa una vez");
            i = 0;
        }
        if (Input.GetButton("Jump"))
        {
            contar();
        }
	}
    private void contar()
    {
        i += Time.deltaTime;
        Debug.Log(i);
    }
}
