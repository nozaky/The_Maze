using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaDesplazamiento : MonoBehaviour {
    private GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = new Vector3(10,1,7);
    }
}
