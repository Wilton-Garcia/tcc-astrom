using UnityEngine;
using UnityEngine.UI;

public class GerenciamentoUISelecaoSimulacao : MonoBehaviour {
    public Text textoBtn1;


    private void Start()
    {
        textoBtn1.text = StringsGlobais.textoOpcaoSelecaoSimulcao1;
    }
}
