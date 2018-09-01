using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terra : MonoBehaviour {

    public double velocidadeTranslacao;
    public int velocidadeRotacao;

     public static Terra Singleton;

    
    private void fazRotacao()
    {
        transform.Rotate(new Vector3(0,5,0), Time.deltaTime * velocidadeRotacao);
    }

    public void paraRotacao()
    {
        velocidadeRotacao = 0;
    }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        fazRotacao();
    }

    public Terra()
    {
        velocidadeRotacao = 5;
        velocidadeTranslacao = 5;
    }
}
