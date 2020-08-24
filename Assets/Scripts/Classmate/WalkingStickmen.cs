using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingStickmen :  Number
{
    bool povorot;
    public float speed, degree1, degree2, A, Bdist, dist;
    public int ForwardRight;
    private float counter;
    public Transform B;

    void Update()
    {
        counter += Time.deltaTime;
        dist = Vector3.Distance(transform.position, B.position);
        if (ForwardRight == 1)
        {
           transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (ForwardRight == 2)
        {
            transform.position += -Vector3.forward * speed * Time.deltaTime;
        }
        if (ForwardRight == -1)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (ForwardRight == -2)
        {
            transform.position += -Vector3.right * speed * Time.deltaTime;
        }

        if (dist < Bdist && _number == false)
        {
            speed = 0;
            _anim.SetTrigger("Dumaet");
            if (counter > 10)
            {
              _anim.SetTrigger("Walking180");    transform.rotation = Quaternion.Euler(0, degree1, 0);    speed = -1;
              
            }
           
        }
        if (dist > A && _number == false)
        {
            speed = 0;
            _anim.SetTrigger("Dumaet");
            if (counter > 10)
            {
                _anim.SetTrigger("Walking180");    transform.rotation = Quaternion.Euler(0, degree2, 0);   speed = 1;
            }
        }
        if (speed == -1)
            {
                povorot = true;
            }
        else if (speed == 1)
        {
            povorot = false;
        }
        if (_number == true)
        {
            counter = 0;
            speed = 0;
            Invoke("Walking", 6.6f); 
        }
        if (counter > 13)
        {
            counter = 0;
        }
    }
    void Walking()
    {  
                if (povorot == true)
                {
                    speed = -1;
                }
                if (povorot == false)
                {
                    speed = 1;
                }
    }
}
