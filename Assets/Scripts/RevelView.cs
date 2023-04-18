using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class RevelView : MonoBehaviour,IOutput
{
    private int AddUp;
    private string Level;

    public void AddUpChange(int addup) => AddUp = addup;
    public void LevelChange(string level) => Level = level;

    public void Log(string level,int addup)
    {
        Debug.Log(level);
        Debug.Log(addup);
    }

   
}
