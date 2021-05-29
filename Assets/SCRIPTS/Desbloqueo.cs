using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desbloqueo : MonoBehaviour {
    private Animation anim;
    public TextMesh nivel1;
    private string texto1;
    private bool activador;
    public AudioClip openDoor;
    private AudioSource sound;
	// Use this for initialization
	void Start () {
        sound = this.gameObject.GetComponent<AudioSource>();
        anim = GetComponent<Animation>();
        activador = true;
        sound.clip = openDoor;
	}
	
	// Update is called once per frame
	void Update () {
        texto1 = nivel1.text;
        if (texto1== "NIVEL\nDESBLOQUEADO"&& activador == true)
        {
            anim.Play("DesbloqueoNivel");
            sound.Play();
            activador = false;
        }
	}
}
