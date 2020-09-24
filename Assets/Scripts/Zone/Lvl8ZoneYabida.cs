using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl8ZoneYabida : Zone
{
 
    void Update()
    {
        if (Number._number == true)
        {
            gameObject.SetActive(false);
        }
    }
}
