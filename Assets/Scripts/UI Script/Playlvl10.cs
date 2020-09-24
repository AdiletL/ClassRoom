using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playlvl10 : MonoBehaviour
{
   
    public GameObject gaming;
    public Traektorialvl10 _tr;
    public Lvl10Camera cameraAnim;

    private void Start()
    {
        Time.timeScale = 0;
    }
    public void play()
    {
        Time.timeScale = 1;
        gaming.SetActive(true);
        cameraAnim.enabled = true;
        _tr.enabled = true;
        gameObject.SetActive(false);
    }
}
