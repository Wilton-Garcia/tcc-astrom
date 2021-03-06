﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorCenas : MonoBehaviour
{

    /*
     Esta classe é responsável por fazer todo o controle de navegação entre cenas
     toda e qualquer troca de cena deve ser implementada aqui.

    Este objeto deve ser instanciando no objeto Controlador na primeira cena da aplicação.

    IMPORTANTE:

    Esta classe respeita a ordem em que as cenas foram adicionadas ao projeto, essa configuração deve
    ser alterada diretamente em File -> Build Settings -> Build in scenes

    Não implemente métodos que não tenham como função a troca de cenas nesta classe,  

    Esta classe assume que o menu principal sempre vai ser a cena 1, caso seja necessário adicionar cenas
    que deverão aparecer antes da tela de menu, não alterar a ordem das cenas, e sim adicionar a cena
    com o próximo numéro de cena disponivél. Exemplo o projeto tem 6 cenas, e é preciso adicionar mais uma cena
    para exibir uma logo, adicionar esta cena como cena 7, e na cena 0, e implementar um método que chame a cena 7
    antes da cena 1, depois a cena 1 pode ser chamada normalmente

    Não alterar a ordem das seguintes cenas:

    0 - Cena para instanciar o controlador global
    1 - Cena do menu
    2 - Cena das configuraçõess

    As demais cenas podem ser alteradas.
     */
    public static ControladorCenas Singleton;

    private void Awake()
    {
        Singleton = this;
    }
    public int cenaAtual()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
    //Não alterar
    public void acessarMenu()
    {
        Debug.Log("Código Chegou aqui");
        SceneManager.LoadScene(1);
    }
    //Não alterar
    public void acessarConfiguracoes()
    {
        SceneManager.LoadScene(2);
    }
    public void acessaSelecaoExporacao()
    {
        SceneManager.LoadScene(3);
    }
    public void simulaTerra()
    {
        SceneManager.LoadScene(4);
    }
    public void acessaSimulacaoSistemaSolar()
    {
        SceneManager.LoadScene(5);
    }
    public void acessaSelacaoSimulacao()
    {
        SceneManager.LoadScene(6);
    }
    public void acessaSelecaoCuriosidades()
    {
        SceneManager.LoadScene(7);
    }
    public void acessaCuriosidadesPlanetas()
    {
        SceneManager.LoadScene(9);
    }
    public void acessaCuriosidadesEsrelas()
    {
        SceneManager.LoadScene(10);
    }
    public void acessaCuriosidadesOutrosPlanetas()
    {
        SceneManager.LoadScene(11);
    }

    public void acessaInformacoes()
    {
        SceneManager.LoadScene(12);
    }

    public void acessaSimulacaElipseSolar()
    {
        SceneManager.LoadScene(8);
    }
    
}
