using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1Level2 : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("lvl", PlayerPrefs.GetInt("lvl") + 2);
        PlayerPrefs.Save();
    }
}
