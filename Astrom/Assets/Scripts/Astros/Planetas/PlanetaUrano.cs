using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaUrano : Planeta {

    public PlanetaUrano()
    {
        this.modelo3D = Resources.Load("Urano") as GameObject;
        this.nomePlaneta = StringsGlobais.planetaUranoNome;
        this.tempoRotacao = StringsGlobais.planetaUranoTempoRotacao;
        this.tempoTranslacao = StringsGlobais.planetaUranoTempoTranslacao;
        this.distanciaSol = StringsGlobais.planetaUranoDistanciaSol;
    }
}
