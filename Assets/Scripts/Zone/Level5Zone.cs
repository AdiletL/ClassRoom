using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5Zone : Zone
{
    void Update()
    {
        if (player.zone == true || _num._number == true)
        {
            gameObject.SetActive(false);
        }
    }
}
