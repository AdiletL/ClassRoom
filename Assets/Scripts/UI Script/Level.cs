using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public Text[] level;
    private int islvl;

    private void Start()
    {
            islvl = PlayerPrefs.GetInt("lvl");
            level[0].text = islvl.ToString();
            level[1].text = islvl.ToString();        
    }
  
}
