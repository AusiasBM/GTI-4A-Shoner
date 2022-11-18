using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticulasDestruccion : MonoBehaviour
{
    public GameObject[] particulas;

    private static ParticulasDestruccion instance;
    public static ParticulasDestruccion Instance { get => instance; }

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Generar part?culas al colisionar con algunos objetos
    public void generarParticulas(GameObject[] tipoParticulas, Transform objeto)
    {
        int range = Random.Range(0, tipoParticulas.Length);
        Debug.Log(range);
        Vector3 pos = new Vector3(objeto.transform.position.x, objeto.transform.position.y, objeto.transform.position.z);
        GameObject particulas = Instantiate(tipoParticulas[range], pos, Quaternion.identity);
        StartCoroutine(delay(particulas, 1));
    }

    IEnumerator delay(GameObject particulas, int seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(particulas);
    }
}
