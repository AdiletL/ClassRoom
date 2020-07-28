using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryClassroom : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            _animator.SetTrigger("Popadanie");
        }
    }
}
