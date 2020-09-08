using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
   public bool LVL = false;
    public int restar;
    public Randomlvl rand;
   
    public void restartlvl() { restar = 0; SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0); LVL = true; LVL = false; }
    public void nextlvl()
    {
        if (PlayerPrefs.GetInt("re") > 0)
        {
            SceneManager.LoadScene(Random.Range(1,11)); LVL = true; LVL = false;
        }
        else
        {
            restar = 1;
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  LVL = true; LVL = false; }
        }

    
}
   

