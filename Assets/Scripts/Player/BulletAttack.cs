using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAttack : MonoBehaviour
{
    public Traektoria play;
    
    private void Update()
    {
        if (play.att == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
