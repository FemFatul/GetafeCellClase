using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningQuad : MonoBehaviour {
    [SerializeField] Camera currentCam;
    private void Update()
    {
        transform.LookAt(new Vector3(
           currentCam.transform.position.x,
           transform.position.y,
        currentCam.transform.position.z));
        
    }
}
