using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zonelvl10 : OnandOff
{
    public Traektorialvl10 pl;
    public Number numeration;
    void Update()
    {
        if (pl.zone == true || numeration.thasd == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
