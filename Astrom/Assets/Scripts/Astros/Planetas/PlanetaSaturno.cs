using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaSaturno : Planeta {

    public PlanetaSaturno()
    {
        this.modelo3D = Resources.Load("Saturno") as GameObject;
        this.nomePlaneta = StringsGlobais.planetaSaturnoNome;
        this.tempoRotacao = StringsGlobais.planetaSaturnoTempoRotacao;
        this.tempoTranslacao = StringsGlobais.planetaSaturnoTempoTranslacao;
        this.distanciaSol = StringsGlobais.planetaSaturnoDistanciaSol;

        velocidadeRotacao = 4;
    }
}
