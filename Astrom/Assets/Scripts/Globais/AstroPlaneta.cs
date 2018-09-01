using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AstroPlaneta : MonoBehaviour {


    public Text nomePlaneta;
    public Text categoriaPlaneta;
    public Text tempoTranslacaoPlaneta;
    public Text tempoRotacaoPlaneta;
    public Text distanciaSol;

    public GameObject astro3D;

    public Planeta planeta;




    public void mudaPlaneta(Planeta novoPlaneta)
    {
        planeta = novoPlaneta;
        astro3D = novoPlaneta.modelo3D;
        nomePlaneta.text = novoPlaneta.nomePlaneta;
        categoriaPlaneta.text = StringsGlobais.definicaoComumAstrosCategoria + novoPlaneta.categoriaPlaneta;
        tempoRotacaoPlaneta.text = StringsGlobais.definicaoComumAstrosTempoRotacao + novoPlaneta.tempoRotacao;
        tempoTranslacaoPlaneta.text = StringsGlobais.definicaoComumAstrosTempoTranslacao + novoPlaneta.tempoTranslacao;
        distanciaSol.text = StringsGlobais.definicaoComunsAstrosDistanciaSol + novoPlaneta.distanciaSol;

    }

	// Use this for initialization
	void Start () {
        Instantiate(astro3D, this.transform.position, this.transform.rotation);
        PlanetaTerra terra = new PlanetaTerra();
        mudaPlaneta(terra);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
