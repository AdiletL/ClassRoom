using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5Zone : Zone
{
    public Traektoria pl;
    public Number num;
    void Update()
    {
        if (pl.zone == true || num.thasd == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
