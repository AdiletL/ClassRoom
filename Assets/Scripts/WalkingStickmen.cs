using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingStickmen :  MonoBehaviour
{
    public float speed;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
        if (transform.position.z > 7)
        {
            speed = -speed; 
            
             Invoke("Walking180", 1);
        }
        else if (transform.position.z < -1f)
        {
            speed = -speed;
            Invoke("Walking180", 1);
        }
    }
    void Walking180() {  }
}
