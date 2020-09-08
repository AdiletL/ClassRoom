using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public Text[] level;
    private int islvl, lvl;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("restart") == 1 )
        {
            lvl = 0;
           
        }
        if (PlayerPrefs.GetInt("restart") == 2)
        {
            lvl = 1;
        }
    }

    private void Start()
    {
      


            PlayerPrefs.SetInt("lvl", PlayerPrefs.GetInt("lvl") + lvl);  //PlayerPrefs.SetInt("lvl",PlayerPrefs.GetInt("lvl")+1);PlayerPrefs.SetInt("lvl",lvl);
            PlayerPrefs.Save();
            islvl = PlayerPrefs.GetInt("lvl");
            level[0].text = islvl.ToString();
            level[1].text = islvl.ToString();
        
    }
  
}
