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

        Bind();
    }
    void Bind()
    {
       //RevelData.GetRevel()
       //     .Where(x=>RevelData.GetRevel()== )
    }
  
}
