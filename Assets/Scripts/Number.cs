using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
   [HideInInspector]  public bool _number = false;
    private Animator _anim;
    private BoxCollider _Box;

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
            _Box.center = new Vector3(5, 5, 5);
        }
    }
}
