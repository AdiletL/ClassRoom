using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingStickmen :  Number
{
    bool povorot;
    public float speed=1, degree1, degree2, A, Bdist, dist;
    public int ForwardRight;
    private float counter;
    public float unterval;
    public float EndStart;
    public Transform B;
    private int plusSpeed, minusSpeed;
   

    private void Start()
    {
        if (PlayerPrefs.GetInt("re") == 1)
        {
            speed = 2;
            plusSpeed = 2;
            minusSpeed = -2;
        }
        else
        {
            speed = 1;
            plusSpeed = 1;
            minusSpeed = -1;
        }
    }

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

        if (dist < Bdist && number == false)
        {
            speed = 0;
            _anim.SetTrigger("Dumaet");
            if (counter > unterval)
            {
              _anim.SetTrigger("Walking180");    transform.rotation = Quaternion.Euler(0, degree1, 0);    speed = minusSpeed;
              
            }
           
        }
        if (dist > A && number == false)
        {
            speed = 0;
            _anim.SetTrigger("Dumaet");
            if (counter > unterval)
            {
                _anim.SetTrigger("Walking180");    transform.rotation = Quaternion.Euler(0, degree2, 0);   speed = plusSpeed;
            }
        }
        if (speed == minusSpeed)
            {
                povorot = true;
            }
        else if (speed == plusSpeed)
        {
            povorot = false;
        }
        if (thasd == 1)
        {
            counter = 0;
            speed = 0;
            Invoke("Walking", 6.6f);
            thasd = 0;
        }

        if (counter > EndStart)
        {
            counter = 0;
        }
    }
    void Walking()
    {
        
                if (povorot == true)
                {
                    speed = minusSpeed;
                }
                if (povorot == false)
                {
                    speed = plusSpeed;
                }
    }
}
