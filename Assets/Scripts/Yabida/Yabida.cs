using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yabida : Number
{
    public float Rotate1, Rotate2, speed, StartInterval;
    public GameObject Particle;
    public Transform Object;
    public Traektoria player;
  
    private float counter;
    
    void Update()
    {
        counter += Time.deltaTime;

        if (_number == true)
        {
            speed = 0;
            
        }
        if (speed==0)
        {
transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), 1 * Time.deltaTime);
        }
        if (player.zone == false)
        {
            if (counter <= StartInterval)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, Rotate1, 0), speed * Time.deltaTime);
               
            }
            if (counter >= 7)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, Rotate2, 0), speed * Time.deltaTime);
            }
            if (counter >= 14)
            {
                counter = 0;
            }
        }
        if (player.zone == true)
        {
            _anim.SetTrigger("Yabida");
        }
       
    }
    void Particl() { Instantiate(Particle, Object.position, transform.rotation); } 
}
