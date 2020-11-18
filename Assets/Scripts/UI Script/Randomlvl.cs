using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomlvl : MonoBehaviour
{
    public int rand, inlvl;
    public void Random() {
        rand = 0;
        PlayerPrefs.SetInt("re", PlayerPrefs.GetInt("re") +1);  //PlayerPrefs.SetInt("lvl",PlayerPrefs.GetInt("lvl")+1);PlayerPrefs.SetInt("lvl",lvl);
        PlayerPrefs.Save();
   
        inlvl = PlayerPrefs.GetInt("re");
    } 
}
