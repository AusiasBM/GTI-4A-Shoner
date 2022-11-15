using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class ColisionConBala : MonoBehaviour
{
    
    Personaje personaje;
    ParticulasDestruccion particulasDestruccion;
    // Start is called before the first frame update
    void Start()
    {
        personaje = Personaje.Instance;
        particulasDestruccion = ParticulasDestruccion.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bala") gameObject.SetActive(false);
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }


}
