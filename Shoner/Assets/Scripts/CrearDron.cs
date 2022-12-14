using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class CrearDron : MonoBehaviour
{
    private PoolDrones pool;

    public bool activo = true;

    public float radioEsferaCreacion = 75f;

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

        // Definimos la posici?n random desde la que saldr?
        // Random.onUnitSphere * rangoCreacion elige un punto dentro de una esfera (rangoCreaci?n es el radio de la esfera)
        pos = transform.position + Random.onUnitSphere * radioEsferaCreacion;
        

        GameObject obj = pool.chooseDrone();
        if (obj != null)
        {
            //Alejamos la creaci?n de los drones en la posici?n Z por las animaciones
            pos = new Vector3(pos.x, pos.y-20, pos.z + 75f);
            obj.transform.position = pos;
            obj.transform.parent = transform;
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
