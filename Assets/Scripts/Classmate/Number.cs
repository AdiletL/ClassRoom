using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    [HideInInspector] public static bool _number = false;
    [HideInInspector] public  bool number = false;
    public Animator _anim;
   public BoxCollider _Box;
    public int thasd = 0;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _Box = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            _anim.SetTrigger("Popadanie");
           number = true;
            number = false;
            _number = true;
            thasd = 1;
            _Box.enabled = false;
            
        }
    }
}
