using UnityEngine;
using UnityEngine.UI;

public class GerenciamentoUISelecaoSimulacao : MonoBehaviour {
    public Text textoBtn1;
    public Text textoBtn2;


    private void Start()
    {
        textoBtn1.text = StringsGlobais.textoOpcaoSelecaoSimulacao1;
        textoBtn2.text = StringsGlobais.textoOpcapSelecaoSimulacao2;

    }
}
