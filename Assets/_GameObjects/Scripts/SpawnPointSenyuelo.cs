using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointSenyuelo : MonoBehaviour {

    public class SenuyeloGenerator : MonoBehaviour
    {
        [SerializeField] GameObject prefabSenuyelo;
        [SerializeField] float force;
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                GameObject ps = Instantiate(prefabSenuyelo, transform.position, transform.rotation);
                ps.GetComponent<Rigidbody>().AddForce(transform.forward * force);
            }
        }
    }

}
