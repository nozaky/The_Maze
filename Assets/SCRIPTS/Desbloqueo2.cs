using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desbloqueo2 : MonoBehaviour {
    private Animation anim;
    public TextMesh nivel2;
    private string texto;
    private bool activador;
    public AudioClip openDoor;
    private AudioSource sound;
    // Use this for initialization
    void Start()
    {
        sound = this.gameObject.GetComponent<AudioSource>();
        anim = GetComponent<Animation>();
        activador = true;
        sound.clip = openDoor;
    }

    // Update is called once per frame
    void Update()
    {
        texto = nivel2.text;
        if (texto == "NIVEL\nDESBLOQUEADO" && activador == true)
        {
            anim.Play("DesbloqueoNivel2");
            sound.Play();
            activador = false;
        }
    }
}
