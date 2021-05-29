using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioChoque : MonoBehaviour {
    private AudioSource objetoChoque;
	// Use this for initialization
	void Start () {
        objetoChoque = this.gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        objetoChoque.Play();
    }
}
