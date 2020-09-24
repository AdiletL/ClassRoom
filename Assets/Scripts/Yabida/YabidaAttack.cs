using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YabidaAttack : Number
{
    public int sped;
    public Transform pl;
    public GameObject obje;
    public Transform player;
    private float counter;
    private float interval;
    private Vector3 sdf;
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 3)
        {
            _anim.SetTrigger("Attack");
        }
        if (counter >= 6)
        {
            counter = 0;
        }
    }
   public void Attack()
    {
        sdf = player.position;
        GameObject g = Instantiate(obje.gameObject,pl.position, transform.rotation);
        g.GetComponent<Rigidbody>().velocity = Vector3.forward * sped ;
    }
}
