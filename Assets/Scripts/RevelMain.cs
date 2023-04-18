using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class RevelMain : MonoBehaviour
{
    
   

    [Inject]
    void ConstructPresenter(IRevelData revelData,  IOutput output)
    {
        var Presenter = new RevelPresenter(revelData,output);
    }


   
}
