using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControladorMestre : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(ControladorCenas.Singleton.cenaAtual() == 0)
        {
            ControladorCenas.Singleton.acessarMenu();
        }
	}
}
