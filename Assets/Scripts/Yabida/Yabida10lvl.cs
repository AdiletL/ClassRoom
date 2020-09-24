using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yabida10lvl : Number
{
    public GameObject Particle;
    public Transform Object;
    public Number num;
    public float speed, StartInterval, EndStart;
    private float counter;
    public Traektorialvl10 player;
    void Update()
    {
        counter += Time.deltaTime;

        if (num.thasd == 1)
        {
            speed = 0;
        }
        if (speed == 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), 1 * Time.deltaTime);
        }
        if (player.zone == false)
        {
            if (counter <= StartInterval)
            {
                transform.Rotate(-Vector3.up * speed * Time.deltaTime);

            }
            if (counter >= StartInterval)
            {
                transform.Rotate(Vector3.up * speed * Time.deltaTime);
            }
            if (counter >= EndStart)
            {
                counter = 0;
            }
        }
        if (player.zone == true)
        {
            _anim.SetTrigger("Yabida");
        }

    }
    void Particl() { Instantiate(Particle, Object.position, transform.rotation); }
}
