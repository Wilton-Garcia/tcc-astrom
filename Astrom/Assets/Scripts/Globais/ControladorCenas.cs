using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
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


    //Não alterar
    public void acessarMenu()
    {
        SceneManager.LoadScene(1);
    }
    //Não alterar
    public void acessarConfiguracoes()
    {
        SceneManager.LoadScene(2);
    }
   

}
