using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Desactivartodosloselementos();
            vehiculos[Random.Range(0,vehiculos.Length)].SetActive(true);
        }
    }

    void ResetearVehiculos()
    {
        //desactivar todos los elementos del array
        //activar solo el primer elemento
        
    }
    void Desactivartodosloselementos()
    {
    for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }
    }
}
