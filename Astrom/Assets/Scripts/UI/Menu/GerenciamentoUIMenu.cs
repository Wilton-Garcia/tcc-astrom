using UnityEngine;
using UnityEngine.UI;

public class GerenciamentoUIMenu : MonoBehaviour
{
    public Text logoPrincipal;

    public Text textoBtn1;
    public Text textoBtn2;
    public Text textoBtn3;

 

    void Start()
    {
        logoPrincipal.text = StringsGlobais.textoLogo;

        textoBtn1.text = StringsGlobais.textoOpcaoMenu1;
        textoBtn2.text = StringsGlobais.textoOpcaoMenu2;
        textoBtn3.text = StringsGlobais.textoOpcaoMenu3;
           
    }

}
