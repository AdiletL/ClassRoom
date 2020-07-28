using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classmate : MonoBehaviour
{
    private Animator _anim;

    


    private void Start()
    {
        _anim = GetComponent<Animator>();
      
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
          
          _anim.SetTrigger("Popadanie");
        }
        
    }
    
    
}
