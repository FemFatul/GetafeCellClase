using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum Estado { Idle, Walking, Running, Dead }
    private Estado state;

    private const string ANIM_ISWALKING = "isWalking";
    private const string ANIM_ISRUNNING = "isRunning";
    private float y;
    private float x;
    private Animator animador;

    public Estado State {
        get {
            return state;
        }

        set {
            state = value;
        }
    }
    private void Awake()
    {
        animador = GetComponent<Animator>();
        state = Estado.Idle;
    }
    void Update()
    {
        if (state != Estado.Dead)
        {

            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");
            if (y > 0.1f)
            {
                Avanzar();
            }
            else
            {
                Parar();
            }
            if (x != 0)
            {
                Rotar();
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Correr();
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                DejarDeCorrer();
            }
        }
    }
    private void Avanzar()
    {
        if (state != Estado.Running)
        {
            animador.SetBool(ANIM_ISWALKING, true);
            state = Estado.Walking;
        }
    }
    private void Parar()
    {
        animador.SetBool(ANIM_ISWALKING, false);
        DejarDeCorrer();
        state = Estado.Idle;
    }
    private void Rotar()
    {
        transform.Rotate(0, x, 0);
    }
    private void Correr()
    {
        animador.SetBool(ANIM_ISRUNNING, true);
        state = Estado.Running;
    }
    private void DejarDeCorrer()
    {
        animador.SetBool(ANIM_ISRUNNING, false);
        state = Estado.Walking;
    }
    public void Kill()
    {
        state = Estado.Dead;
        animador.SetTrigger("isDead");
    }
}

