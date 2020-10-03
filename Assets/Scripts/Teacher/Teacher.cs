using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : Number
{

    public Traektoria player;
    private float counter;
    public float StartInterval;



    void Update()
    {

        counter += Time.deltaTime;
        if (counter <= StartInterval)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -65, 0), Time.deltaTime);
            
        }
        if (counter >= StartInterval)
        {
transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -110, 0), Time.deltaTime);
        }

        if (counter >= 14)
        {
            counter = 0;
        }
        if (player.zone == true)
        {
            
            StartInterval = 0;
            _anim.SetTrigger("Popadanie");
        }

    }
    
   
}
