using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl8Zone : Zone
{
    public Lvl8Teacher teacher;


   

    void Update()
    {
      
            if (teacher.rotation == true)
            {  if (_number.thasd != 1)
        {
                spr.enabled = true;
            }
            else
            {
                spr.enabled = false;
            }
   
         
        }
       if (teacher.rotation == false)
            {
                spr.enabled = false;
            }
    }
}
