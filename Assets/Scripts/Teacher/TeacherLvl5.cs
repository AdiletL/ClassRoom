using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherLvl5 :Number
{
    private int speed = 1;
    public Traektoria player;
    public float counter;


    void Update()
    {
       
        if (player.zone == true)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -90, 0), speed * Time.deltaTime);

            _anim.SetTrigger("Popadanie");
            
        }
        if (player.zone == false)
        {


            if (_Box.enabled == false && counter <= 6)
            {
                counter += Time.deltaTime;
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -90, 0), speed * Time.deltaTime);

            }

            if (counter > 6)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), speed * Time.deltaTime);
            }
            if (counter > 15)
            {
                counter = 0;
            }
        }
    }
  

}
