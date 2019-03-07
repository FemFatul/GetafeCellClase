using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour {
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
            

    }
    public void OpenDoors()
    {
        animator.SetBool("Opened", true);
    }
        
   

}
