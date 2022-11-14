using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


[DefaultExecutionOrder(-500)]
public class PoolDrones : MonoBehaviour
{
    public GameObject[] prefab;

    public int amount = 3;

    protected Dictionary<GameObject, int> objetosPrioridades = new Dictionary<GameObject, int>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < prefab.Length; i++)
        {
            for (int j = 0; j < amount; j++)
            {
                GameObject obj = Instantiate(prefab[i]);
                obj.SetActive(false);
                objetosPrioridades.Add(obj, i);
            }
        }

    }

    public GameObject chooseDrone()
    {
        Debug.Log("Entra en chooseDrone");
        int r = Random.Range(0, prefab.Length);
        Dictionary<GameObject, int> objetosNoActivos = new Dictionary<GameObject, int>();

        foreach (KeyValuePair<GameObject, int> item in objetosPrioridades)
        {
            if (!item.Key.activeInHierarchy)
            {
                objetosNoActivos.Add(item.Key, item.Value);

            }
        }

        foreach (KeyValuePair<GameObject, int> item in objetosNoActivos)
        {
            if (r == item.Value && !item.Key.activeInHierarchy)
            {
                item.Key.SetActive(true);
                return item.Key;
            }
        }

        return default(GameObject);
    }

    public void deactivateAllObjects()
    {
        foreach (GameObject gb in prefab)
        {
            if (gb.activeInHierarchy)
            {
                gb.SetActive(false);
            }
        }
    }


}

