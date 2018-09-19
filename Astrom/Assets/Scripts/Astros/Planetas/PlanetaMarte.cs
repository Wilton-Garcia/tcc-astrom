using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaMarte : Planeta {

    public PlanetaMarte()
    {
        this.modelo3D = Resources.Load("Marte") as GameObject;
        this.nomePlaneta = StringsGlobais.planetaMarteNome;
        this.tempoRotacao = StringsGlobais.planetaMarteTempoRotacao;
        this.tempoTranslacao = StringsGlobais.planetaMarteTempoTranslacao;
        this.distanciaSol = StringsGlobais.planetaMarteDistanciaSol;

        velocidadeRotacao = 4;
    }
}
