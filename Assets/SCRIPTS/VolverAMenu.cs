using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverAMenu : MonoBehaviour {
    public string menu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        VariablesGlobales.cont += 1;
        SceneManager.LoadScene(menu);
    }
}
