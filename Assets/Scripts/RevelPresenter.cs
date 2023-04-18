using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using System.Linq;


public class RevelPresenter 
{
    IRevelData RevelData = default;
    IOutput Output = default;
    //RevelView View = default;
    public RevelPresenter(IRevelData revelData,IOutput output)
    {
        RevelData = revelData;
        //View = revelView;
        Output = output;

        
        output.Log(RevelData.GetRevel(),RevelData.GetAddUp());
        Bind();
    }
    void Bind()
    {
        RevelData.GetRevel();
        RevelData.GetAddUp();
        

    }
  
}
