﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart10lvl : MonoBehaviour
{
    public Lvl10Camera _camera;
    public int ler;
    private void FixedUpdate()
    {
        if (_camera.level == 1)
        {
            ler = 1;
            PlayerPrefs.SetInt("restart", ler);
            PlayerPrefs.Save();
            PlayerPrefs.GetInt("restart");
        }
        if (_camera.level == 2)
        {
            ler = 2;
            PlayerPrefs.SetInt("restart", ler);
            PlayerPrefs.Save();
            PlayerPrefs.GetInt("restart");
        }
    }
}