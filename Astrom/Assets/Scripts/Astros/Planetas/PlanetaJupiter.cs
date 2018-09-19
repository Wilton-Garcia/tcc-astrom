using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaJupiter : Planeta
{
    public PlanetaJupiter()
    {
        this.modelo3D = Resources.Load("Jupiter") as GameObject;
        this.nomePlaneta = StringsGlobais.planetaJupiterNome;
        this.tempoRotacao = StringsGlobais.planetaJupiterTempoRotacao;
        this.tempoTranslacao = StringsGlobais.planetaJupiterTempoTranslacao;
        this.distanciaSol = StringsGlobais.planetaJupiterDistanciaSol;

        velocidadeRotacao = 5;
    }
}
