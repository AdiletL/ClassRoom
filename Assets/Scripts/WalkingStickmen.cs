using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingStickmen :  Number
{
    public float speed;
    
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
        if (_number == true)
        {
            speed = 0;
        }
        
        if (transform.position.z > 7.2f)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0); speed = -1; 
        }
        else if (transform.position.z < -1f)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0); speed = 1;
        }
    }
   
}
