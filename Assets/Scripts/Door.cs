using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator ani;
    private void Awake()
    {
        ani = GetComponent<Animator>();
    }
    public void Down()
    {
        ani.SetTrigger("Down");
    }
}
