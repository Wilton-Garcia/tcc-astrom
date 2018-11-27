using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciamentoUIInformacoes : MonoBehaviour {

    public Text info;

	// Use this for initialization
	void Start () {
        info.text = StringsGlobais.informacoesGeral;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
