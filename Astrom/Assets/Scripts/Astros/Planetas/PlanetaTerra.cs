using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaTerra : Planeta {

	public PlanetaTerra()
    {
                                             
        this.modelo3D = Resources.Load("Terra") as GameObject;
        this.nomePlaneta = StringsGlobais.planetaTerraNome;
        this.tempoRotacao = StringsGlobais.planetaTerraTempoRotacao;
        this.tempoTranslacao = StringsGlobais.planetaTerraTempoTranslacao;
        this.distanciaSol = StringsGlobais.planetaTerraDistanciaSol;

        velocidadeRotacao = 24;



    }
}
