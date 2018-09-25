using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamerasSimulacaoSistemaSolar : MonoBehaviour {


    public Camera cam1;
    public Camera cam2;

	public void Camera1()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }
    public void Camera2()
    {
        cam2.enabled = true;
        cam1.enabled = false;
    }

}
