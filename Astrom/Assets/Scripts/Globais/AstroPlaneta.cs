using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AstroPlaneta : MonoBehaviour
{


    public Text nomePlaneta;
    public Text categoriaPlaneta;
    public Text tempoTranslacaoPlaneta;
    public Text tempoRotacaoPlaneta;
    public Text distanciaSol;

    public GameObject astro3D;
    private GameObject instanciaAstro3D;


    public Planeta planeta;

    public int indicePlanetaAtual;


    private Planeta[] ListaPlaneta = new Planeta[3];

    public void proxPlaneta()
    {
        if (indicePlanetaAtual < ListaPlaneta.Length - 1)
        {
            indicePlanetaAtual++;
            mudaPlaneta(ListaPlaneta[indicePlanetaAtual]);

        }
        else
        {
            indicePlanetaAtual = 0;
            mudaPlaneta(ListaPlaneta[indicePlanetaAtual]);
        }
    }
    public void planetaAnterior()
    {
        if (indicePlanetaAtual >= 1)
        {
            indicePlanetaAtual--;
            mudaPlaneta(ListaPlaneta[indicePlanetaAtual]);

        }
        else
        {
            indicePlanetaAtual = ListaPlaneta.Length-1;
            mudaPlaneta(ListaPlaneta[indicePlanetaAtual]);
        }
    }



    public void mudaPlaneta(Planeta novoPlaneta)
    {

        GameObject[] clones = GameObject.FindGameObjectsWithTag("Clone");
        foreach (var clone in clones)
        {
            Destroy(clone);
        }
        astro3D = Instantiate(novoPlaneta.modelo3D, this.transform.position, this.transform.rotation);
        nomePlaneta.text = novoPlaneta.nomePlaneta;
        categoriaPlaneta.text = StringsGlobais.definicaoComumAstrosCategoria + novoPlaneta.categoriaPlaneta;
        tempoRotacaoPlaneta.text = StringsGlobais.definicaoComumAstrosTempoRotacao + novoPlaneta.tempoRotacao;
        tempoTranslacaoPlaneta.text = StringsGlobais.definicaoComumAstrosTempoTranslacao + novoPlaneta.tempoTranslacao;
        distanciaSol.text = StringsGlobais.definicaoComunsAstrosDistanciaSol + novoPlaneta.distanciaSol;



    }

    // Use this for initialization
    void Start()
    {

   
        PlanetaTerra terra = new PlanetaTerra();
        PlanetaMarte marte = new PlanetaMarte();
        PlanetaMercurio mercurio = new PlanetaMercurio();

        ListaPlaneta[0] = terra;
        ListaPlaneta[1] = marte;
        ListaPlaneta[2] = mercurio;



      //  Debug.Log(ListaPlaneta[0].nomePlaneta + ListaPlaneta[1].nomePlaneta + ListaPlaneta[2].nomePlaneta);

        mudaPlaneta(terra);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
