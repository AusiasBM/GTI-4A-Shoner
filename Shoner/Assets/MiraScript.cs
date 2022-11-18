using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraScript : MonoBehaviour
{

    public GameObject Mira;
    public GameObject Camera;


    public void MostrarMira()
    {
        Mira.SetActive(true);
        Camera.SetActive(true);
    }

    public void OcultarMira()
    {
        Mira.SetActive(false);
        Camera.SetActive(false);
    }
}
