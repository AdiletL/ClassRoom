using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart10lvl : MonoBehaviour
{
  
    public int ler;
    private void FixedUpdate()
    {
        if (Lvl10Camera.level == 1)
        {
            ler = 1;
            PlayerPrefs.SetInt("restart", ler);
            PlayerPrefs.Save();
            PlayerPrefs.GetInt("restart");
        }
        if (Lvl10Camera.level == 2)
        {
            ler = 2;
            PlayerPrefs.SetInt("restart", ler);
            PlayerPrefs.Save();
            PlayerPrefs.GetInt("restart");
        }
    }
}
