using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    [HideInInspector] public bool _number = false;
    public Animator _anim;
   [HideInInspector] public BoxCollider _Box;
  

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
            _number = true;
            _Box.enabled = false;
        }
    }
}
