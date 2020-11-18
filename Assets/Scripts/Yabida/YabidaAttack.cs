using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YabidaAttack : Number
{
    bool timing = false;
    public Transform PosBull;
    public GameObject bullet;
    public Transform player;
    private float counter;
    private float interval, intervalthasd;
    public float Degree1, Degree2, SpeedTime;
    void FixedUpdate()
    {
        interval += Time.deltaTime;
        counter += Time.deltaTime;
        if (thasd != 1)
        {
            if (interval >= 3.5f && counter >= 3.5f)
            {
                _anim.SetTrigger("Attack");
                interval = 0;
            }
            if (counter >= 2f && counter <= 4f)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, Degree1, 0), SpeedTime * Time.deltaTime);
            }
            if (counter >= 4)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, Degree2, 0), SpeedTime * Time.deltaTime);
                if (counter >= 5)
                {
                    counter = 0;
                }
            }
        }
        else
        {
            
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), 1 * Time.deltaTime);
           
        }
    }
   public void Attack()
    {
        
        GameObject g = Instantiate(bullet.gameObject,PosBull.position, transform.rotation) ;
        g.GetComponent<Rigidbody>().velocity = (player.position - transform.position) * .5f;
    }

}
