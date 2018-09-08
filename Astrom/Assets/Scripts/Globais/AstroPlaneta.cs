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


    private Planeta[] ListaPlaneta = new Planeta[8];

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
        

        ListaPlaneta[0] = new PlanetaMercurio();
        ListaPlaneta[1] = new PlanetaVenus();
        ListaPlaneta[2] = new PlanetaTerra();
        ListaPlaneta[3] = new PlanetaMarte();
        ListaPlaneta[4] = new PlanetaJupiter();
        ListaPlaneta[5] = new PlanetaSaturno();
        ListaPlaneta[6] = new PlanetaUrano();
        ListaPlaneta[7] = new PlanetaNetuno();


        mudaPlaneta(ListaPlaneta[2]);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
