using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaVenus : Planeta {


    public PlanetaVenus()
    {
        this.modelo3D = Resources.Load("Venus") as GameObject;
        this.nomePlaneta = StringsGlobais.planetaVenusNome;
        this.tempoRotacao = StringsGlobais.planetaVenusTempoRotacao;
        this.tempoTranslacao = StringsGlobais.planetaVenusTempoTranslacao;
        this.distanciaSol = StringsGlobais.planetaVenusDistanciaSol;

        velocidadeRotacao = 1;
    }

}
