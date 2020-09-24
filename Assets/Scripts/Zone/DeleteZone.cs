using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteZone : MonoBehaviour
{
   
    public Number num;
    void Update()
    {
        if ( num.thasd == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
