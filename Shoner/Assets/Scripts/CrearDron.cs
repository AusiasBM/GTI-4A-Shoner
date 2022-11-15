using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class CrearDron : MonoBehaviour
{
    private PoolDrones pool;

    public bool activo = true;

    public float radioEsferaCreacion = 50f;

    // Start is called before the first frame update
    void Start()
    {
       /* ralentizador = RalentizadorVelocidad.Instance;
        maquina = MaquinaFSM.Instance;*/
        pool = GetComponent<PoolDrones>();
    }

    void activateObjet()
    {
        Vector3 pos = new Vector3(0, 0, 0);

        // Definimos la posición random desde la que saldrá
        // Random.onUnitSphere * rangoCreacion elige un punto dentro de una esfera (rangoCreación es el radio de la esfera)
        pos = transform.position + Random.onUnitSphere * radioEsferaCreacion;

        GameObject obj = pool.chooseDrone();
        if (obj != null)
        {
            pos = new Vector3(pos.x, pos.y, transform.position.z + 50f);
            obj.transform.position = pos;
        }
        

        Invoke("activateObjet", 2f);
    }

    void OnEnable()
    {
        Debug.Log("Activo!!!!!!!!!!!!!!!!!!");
        Invoke("activateObjet", 0.5f);
    }

    void OnDisable()
    {
        Debug.Log("DESACTIVADO!!!!!!!");
        CancelInvoke();

    }

}
