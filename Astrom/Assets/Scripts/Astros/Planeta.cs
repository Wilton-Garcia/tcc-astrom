using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Planeta : MonoBehaviour{

    public GameObject modelo3D;

    public string nomePlaneta;
    public string categoriaPlaneta = StringsGlobais.definicaoNomeAstroPlaneta;

    public string tempoRotacao;
    public string tempoTranslacao;

    public string distanciaSol;

    public GameObject prefab;


    public int numeroSatalite;
    //Diametro Equatorial
    public string tamanhoEquado;

    public double velocidadeRotacao;
    public double velocidadeTranslacao;

    public void DestruirObjeto()
    {
        Destroy(this.gameObject);
    }
}
