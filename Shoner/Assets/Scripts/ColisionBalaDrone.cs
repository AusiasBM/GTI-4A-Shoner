using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBalaDrone : MonoBehaviour
{

    ParticulasDestruccion particulasDestruccion;
    // Start is called before the first frame update
    void Start()
    {
        particulasDestruccion = ParticulasDestruccion.Instance;
    }


    private void OnTriggerEnter(Collider other)
    {
        ScoreCounter.Instance.IncreaseScore();
        particulasDestruccion.generarParticulas(particulasDestruccion.particulas, other.gameObject.transform);
        other.gameObject.transform.parent.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
