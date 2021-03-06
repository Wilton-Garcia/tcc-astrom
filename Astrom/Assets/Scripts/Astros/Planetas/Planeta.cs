﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Planeta : MonoBehaviour{

    public GameObject modelo3D;

    public string nomePlaneta;
    public string categoriaPlaneta = StringsGlobais.definicaoNomeAstroPlaneta;
    public string tempoRotacao;
    public string tempoTranslacao;
    public string distanciaSol;

    public int anguloRotacao = 0;

    public GameObject prefab;


    public int numeroSatalite;
    //Diametro Equatorial
    public string tamanhoEquado;

    public int velocidadeRotacao;
    public int velocidadeTranslacao;

    public void MovimentoRotacao()
    {
       
            transform.Rotate(new Vector3(0, 5, 0), Time.deltaTime * 5);
       
    }

    public void DestruirObjeto()
    {
        Destroy(this.gameObject);
    }

    private void Update()
    {
        MovimentoRotacao();
    }
}
