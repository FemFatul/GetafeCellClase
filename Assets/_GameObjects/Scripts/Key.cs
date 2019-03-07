using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
    public Doors[] puertas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ryan")
        {
            foreach(Doors puerta in puertas)
            {

            }
        }
        
    }
}
