using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAttacklvl10 : MonoBehaviour
{
    public Traektorialvl10 play;

    private void Update()
    {
        if (play.att == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
