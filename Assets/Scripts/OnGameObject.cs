using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGameObject : MonoBehaviour
{
    public GameObject _on;
    public GameObject _off;
    private void Awake()
    {
        if (PlayerPrefs.GetInt("re") == 1)
        {
            _on.SetActive(true);
            _off.SetActive(false);
        }
    }
}
