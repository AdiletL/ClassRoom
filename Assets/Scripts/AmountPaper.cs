using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmountPaper : MonoBehaviour
{
    public float amount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            amount += 1;
        }
    }
}
