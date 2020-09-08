using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playlvl10 : MonoBehaviour
{
   
    public GameObject gaming;
    public Traektorialvl10 _tr;
    public Lvl10Camera cameraAnim;
 
    public void play()
    {
       
        gaming.SetActive(true);
        cameraAnim.enabled = true;
        _tr.enabled = true;
        gameObject.SetActive(false);
    }
}
