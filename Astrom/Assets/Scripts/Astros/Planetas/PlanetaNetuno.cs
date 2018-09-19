using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaNetuno : Planeta {

    public PlanetaNetuno()
    {
        this.modelo3D = Resources.Load("Netuno") as GameObject;
        this.nomePlaneta = StringsGlobais.planetaNetunoNome;
        this.tempoRotacao = StringsGlobais.planetaNetunoTempoRotacao;
        this.tempoTranslacao = StringsGlobais.planetaNetunoTempoTranslacao;
        this.distanciaSol = StringsGlobais.planetaNetunoDistanciaSol;

        velocidadeRotacao = 5;
    }

}
