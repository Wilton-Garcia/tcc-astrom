using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciamentoUISelecaoCuriosidades : MonoBehaviour {

    public Text TextoBtn1;
    public Text TextoBtn2;
    public Text TextoBtn3;
    


	// Use this for initialization
	void Start () {
        TextoBtn1.text = StringsGlobais.textoOpcaoSelecaoCuriosidadePlanetas;
        TextoBtn2.text = StringsGlobais.textoOpcaoSelecaoCuriosidadeEstrelas;
        TextoBtn3.text = StringsGlobais.textoOpcaoSelecaoCuriosidadeOutrosAstros;
	}
	
}
