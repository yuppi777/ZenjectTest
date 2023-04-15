using UnityEngine;
using Zenject;

public class ATBind : MonoInstaller
{
    [SerializeField] RevelView revelView;
    public override void InstallBindings()
    {
        Container.Bind<IRevelData>()
            .FromInstance(new Revel_L())
            .AsCached();

        
    }
}