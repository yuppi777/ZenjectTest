using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using System.Linq;


public class RevelPresenter 
{
    IRevelData RevelData = default;
    RevelView View = default;
    public RevelPresenter(IRevelData revelData,RevelView revelView)
    {
        RevelData = revelData;
        View = revelView;

        Bind();
    }
    void Bind()
    {
       //RevelData.GetRevel()
       //     .Where(x=>RevelData.GetRevel()== )
    }
  
}
