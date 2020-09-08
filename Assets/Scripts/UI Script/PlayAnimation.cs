using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public GameObject[] Timline;
    
  public  void PlayAnim() { Timline[0].SetActive(true); Timline[1].SetActive(true); }
}
