using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl10zone : MonoBehaviour
{
    public Teacherlvl10 teacher;
    private SpriteRenderer spr;
    public Number ns;
    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (teacher.rotation == true)
        {
            if (ns.thasd != 1)
            {
                spr.enabled = true;
            }
            else
            {
                spr.enabled = false;
            }

        
        }    if (teacher.rotation == false)
            {
                spr.enabled = false;
            }
    }
}
