using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;


public class GerenciamentoUIMenu : MonoBehaviour
{

    public GameObject objetosTelaMenu;


    //Controla os textos de logo na tela de menu
    public Text menu_logo_lbl1;


    //Controla os botões nas telas de menu
    public Button menu_btn1;
    public Button menu_btn2;
    public Button menu_btn3;
    public Button menu_btn4;
    public Button menu_btn5;


    //Define os textos dos botões da tela de menu
    public Text btn_menu_lbl1;
    public Text btn_menu_lbl2;
    public Text btn_menu_lbl3;


    

  

    private void Start()
    {
        StringsPT_BR string_values = new StringsPT_BR();

        






        //Textos dos botões do menu
        btn_menu_lbl1.text = string_values.txt_menu_btn1;
        btn_menu_lbl2.text = string_values.txt_menu_btn2;
        btn_menu_lbl3.text = string_values.txt_menu_btn3;


        //Personalizações dos elementos da tela
        //Logo
        menu_logo_lbl1.text = string_values.txt_logo1;
        menu_logo_lbl1.color = Color.green;
    }

}
