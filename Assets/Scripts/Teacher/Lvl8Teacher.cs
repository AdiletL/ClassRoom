using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl8Teacher : Number
{
    private int speed = 1;
    private float counter;
    private float count;
    public Traektoria player;
    [HideInInspector] public bool rotation = false;

    void Update()
    {
        count += Time.deltaTime;
        if (player.zone == true)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -90, 0), speed * Time.deltaTime);

            _anim.SetTrigger("Losing");
           
        }
        if (player.zone == false)
        {
            if (_Box.enabled == false && counter <= 6)
            {
                counter += Time.deltaTime;
                Povorot();
                if (counter > 6)
                {
                    Povorot90();
                }
                if (counter >= 15)
                {
                    counter = 0;
                }
            }
           
            if (_number == false)
            {
             
                if (count <= 4)
                {
                    Povorot();
                }
                if (count >= 2.5f && count <= 9)
                {
                    rotation = true;
                }
                if (count >= 9)
                {
                    Povorot90();
                }
                if (count >= 9)
                {
                    rotation = false;
                }
            }
        }
       
        if (count >= 15)
        {
            count = 0;
        }
    }
    void Povorot() { transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -90, 0), speed * Time.deltaTime); }
    void Povorot90() { transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), speed * Time.deltaTime); }
   

}
