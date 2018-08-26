using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerencimanetoUIConfiguracoes : MonoBehaviour
{

    public Text txt_menu_label1;
    public Text txt_menu_label2;
    public Text txt_menu_label3;

    //Define componentes que podem ser reaproveitados
    public Text txt_btn_voltar;


    public void Start()
    {
        StringsPT_BR string_values = new StringsPT_BR();

        //Definições de strings globais
        txt_btn_voltar.text = string_values.txt_btn_voltar;

        txt_menu_label1.text = string_values.txt_menu_label1;
        txt_menu_label2.text = string_values.txt_menu_label2;
        txt_menu_label3.text = string_values.txt_menu_label3;
    }
}

