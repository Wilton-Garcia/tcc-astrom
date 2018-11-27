using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciamentoUICuriosidadesPlanetas : MonoBehaviour
{

    public Text txtBtnCuriosidadeMercurio;
    public Text txtBtnCuriosidadeVenus;
    public Text txtBtnCuriosidadeTerra;
    public Text txtBtnCuriosidadeMarte;
    public Text txtBtnCuriosidadeJupiter;
    public Text txtBtnCuriosidadeSaturno;
    public Text txtBtnCuriosidadeUrano;
    public Text txtBtnCuriosidadeNetuno;

    public Text txtGuiaCuriosidades;
    public Text txtCuriosidade;

    void Start()
    {
        txtBtnCuriosidadeMercurio.text = StringsGlobais.planetaMercurioNome;
        txtBtnCuriosidadeVenus.text = StringsGlobais.planetaVenusNome;
        txtBtnCuriosidadeTerra.text = StringsGlobais.planetaTerraNome;
        txtBtnCuriosidadeMarte.text = StringsGlobais.planetaMarteNome;
        txtBtnCuriosidadeJupiter.text = StringsGlobais.planetaJupiterNome;
        txtBtnCuriosidadeSaturno.text = StringsGlobais.planetaSaturnoNome;
        txtBtnCuriosidadeUrano.text = StringsGlobais.planetaUranoNome;
        txtBtnCuriosidadeNetuno.text = StringsGlobais.planetaNetunoNome;

        txtGuiaCuriosidades.text = StringsGlobais.textoCuriosidadesVoceSabia;
        txtCuriosidade.text = StringsGlobais.textoCuriosidadesPadrao;


    }

    public void SelecionaCuriosidade(int code)
    {
        switch (code)
        {
            case 1:
                txtGuiaCuriosidades.text = StringsGlobais.textoCuriosidadeGuiaPlanetas + StringsGlobais.planetaMercurioNome;
                txtCuriosidade.text = StringsGlobais.textoCuriosidadeMercurio;
                break;
            case 2:
                txtGuiaCuriosidades.text = StringsGlobais.textoCuriosidadeGuiaPlanetas + StringsGlobais.planetaVenusNome;
                txtCuriosidade.text = StringsGlobais.textoCuriosidadeVenus;
                break;
            case 3:
                txtGuiaCuriosidades.text = StringsGlobais.textoCuriosidadeGuiaPlanetas + StringsGlobais.planetaTerraNome;
                txtCuriosidade.text = StringsGlobais.textoCuriosidadeTerra;
                break;
            case 4:
                txtGuiaCuriosidades.text = StringsGlobais.textoCuriosidadeGuiaPlanetas + StringsGlobais.planetaMarteNome;
                txtCuriosidade.text = StringsGlobais.textoCuriosidadeMarte;
                break;
            case 5:
                txtGuiaCuriosidades.text = StringsGlobais.textoCuriosidadeGuiaPlanetas + StringsGlobais.planetaJupiterNome;
                txtCuriosidade.text = StringsGlobais.textoCuriosidadeJupiter;
                break;
            case 6:
                txtGuiaCuriosidades.text = StringsGlobais.textoCuriosidadeGuiaPlanetas + StringsGlobais.planetaSaturnoNome;
                txtCuriosidade.text = StringsGlobais.textoCuriosidadeSaturno;
                break;
            case 7:
                txtGuiaCuriosidades.text = StringsGlobais.textoCuriosidadeGuiaPlanetas + StringsGlobais.planetaUranoNome;
                txtCuriosidade.text = StringsGlobais.textoCuriosidadeUrano;
                break;
            case 8:
                txtGuiaCuriosidades.text = StringsGlobais.textoCuriosidadeGuiaPlanetas + StringsGlobais.planetaNetunoNome;
                txtCuriosidade.text = StringsGlobais.textoCuriosidadeNetuno;
                break;
            

        }
    }

    void Update()
    {

    }
}
