using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disparar : MonoBehaviour
{
    //Agregan punto de inicio de donde la bala saldra.
    public GameObject BalaInicio;
    //Agregan Bala Prefab
    public GameObject BalaPrefab;
    //Agregar Bala Velocidad
    public float BalaVelocidad;

    public Button btnDisparar;
 
    void Start()
    {
        btnDisparar.onClick.AddListener(DispararBala);     
    }

    void DispararBala()
    {
        //Crear Bala
        GameObject bala = Instantiate(BalaPrefab);
        //Posicion de la bala
        bala.transform.position = BalaInicio.transform.position;
        //Agregar fuerza a la bala
        bala.GetComponent<Rigidbody>().AddForce(BalaInicio.transform.forward * BalaVelocidad);

        //Destruir bala despues de 2 segundos
        Destroy(bala, 2.0f);
    }

}
