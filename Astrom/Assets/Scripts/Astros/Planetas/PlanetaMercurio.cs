using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaMercurio : Planeta{

    public PlanetaMercurio()
    {
        this.modelo3D = Resources.Load("Mercurio") as GameObject;
        this.nomePlaneta = StringsGlobais.planetaMercurioNome;
        this.tempoRotacao = StringsGlobais.planetaMercurioTempoRotacao;
        this.tempoTranslacao = StringsGlobais.planetaMercurioTempoTranslacao;
        this.distanciaSol = StringsGlobais.planetaMercurioDistanciaSol;

        

        velocidadeRotacao = 24;

    }
}
