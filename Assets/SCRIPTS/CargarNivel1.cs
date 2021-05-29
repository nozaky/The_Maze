using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//********************************************
//***SCRIPT CREADO POR DANIEL MONTERO LÓPEZ***
//********************************************
public class CargarNivel1 : MonoBehaviour
{
    // Use this for initialization
    public string nivel1;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(nivel1);
    }
}
