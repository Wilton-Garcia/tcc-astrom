using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDosPlanetas : MonoBehaviour {


    public bool movimentoTranslacao;
    public int velocidadeRotacao;
    public GameObject sol;

	// Use this for initialization
	void Start () {
        movimentoTranslacao = false;
       
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.RotateAround(sol.transform.position , Vector3.up, velocidadeRotacao * Time.deltaTime);

       
	}
}
