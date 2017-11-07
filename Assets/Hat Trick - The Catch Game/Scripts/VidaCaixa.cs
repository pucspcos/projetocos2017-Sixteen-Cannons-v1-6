using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaCaixa : MonoBehaviour {

    public int vida;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        PerdeVida();
    }
        void PerdeVida()
    {
        vida--;
        if (vida==0)
        {
            Destroy(this.gameObject);
        }
    }
}
