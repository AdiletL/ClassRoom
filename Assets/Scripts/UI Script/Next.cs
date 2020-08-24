using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
   public bool LVL = false;
    public void restart() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0); LVL = true; LVL = false; }
    public void nextlvl() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); LVL = true; LVL = false; }
    public void backlvl() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); LVL = true; LVL = false; }
}
