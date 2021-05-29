using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPlano1 : MonoBehaviour {

    public GameObject plano;
    private int x, y, z;
    // Use this for initialization
	void Start () {
        x = -36;
        y = 0;
        z = -46;
		for(int i = 1; i <= 100; i++)
        {
            Instantiate(plano, new Vector3(x, y, z), Quaternion.identity);
            x = x + 10;
            if (i%10==0)
            {
                x = -36;
                z = z + 10;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
