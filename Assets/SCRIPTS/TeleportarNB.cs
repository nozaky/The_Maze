using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportarNB : MonoBehaviour {

    private GameObject tpBot, player;
    private int numeroAleatorio;
    private float posX, posZ;
    // Use this for initialization
    void Start()
    {
        numeroAleatorio = 0;
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        aleatorio();
        player.transform.position = new Vector3(posX, 1.5f, posZ);

    }
    private void aleatorio()
    {
        numeroAleatorio = (int)Random.Range(1f, 14f);
        string tp = "TPNA" + numeroAleatorio.ToString();
        tpBot = GameObject.Find(tp);
        posX = tpBot.transform.position.x;
        posZ = tpBot.transform.position.z;
    }
}
