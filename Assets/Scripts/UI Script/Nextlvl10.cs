﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nextlvl10 : MonoBehaviour
{
    
    public bool LVL = false;
    public int restar;
    private float counter, interval = 1f;
    public Randomlvl rand;
    private int lvl, g;

    void Update()
    {

        if (Lvl10Camera.level == 1)
        {
            counter += Time.deltaTime;
            if (counter >= interval)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    PlayerPrefs.SetInt("true", 0);
                    PlayerPrefs.Save();
                    restar = 0; SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0); LVL = true; LVL = false;
                }
            }

        }
    }

    
    public void nextlvl()
    {
        if (PlayerPrefs.GetInt("restart") == 1)
        {
            lvl = 0;

        }
        if (PlayerPrefs.GetInt("restart") == 2)
        {
            lvl = 1;
        }
        PlayerPrefs.SetInt("lvl", PlayerPrefs.GetInt("lvl") + lvl);  //PlayerPrefs.SetInt("lvl",PlayerPrefs.GetInt("lvl")+1);PlayerPrefs.SetInt("lvl",lvl);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("true", 1);
        PlayerPrefs.Save();
        if (PlayerPrefs.GetInt("re") == 1)
        {
            g = Random.Range(1, 10);
           

            if (SceneManager.GetActiveScene().buildIndex != g)
            {
                SceneManager.LoadScene(g); LVL = true; LVL = false;
            }
            else
            {
                SceneManager.LoadScene(10); LVL = true; LVL = false;
            }
        }
        else
        {
            restar = 1;
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); LVL = true; LVL = false;
        }
    }

}