// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example {
    using Example;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.IOC;
    using uFrame.Kernel;
    using uFrame.MVVM;
    using UniRx;
    using UnityEngine;
    
    
    public class AssetLoadingServiceBase : uFrame.Kernel.SystemServiceMonoBehavior {
        
        public override void Setup() {
            base.Setup();
            this.OnEvent<StartAssetLoadingCommand>().Subscribe(this.StartAssetLoadingCommandHandler);
        }
        
        public virtual void StartAssetLoadingCommandHandler(StartAssetLoadingCommand data) {
        }
    }
    
    public class SettingServiceBase : uFrame.Kernel.SystemServiceMonoBehavior {
        
        public override void Setup() {
            base.Setup();
        }
    }
    
    public class SceneFlowServiceBase : uFrame.Kernel.SystemServiceMonoBehavior {
        
        public override void Setup() {
            base.Setup();
            this.OnEvent<IntroFinishedEvent>().Subscribe(this.IntroFinishedEventHandler);
            this.OnEvent<AssetLoadingProgressEvent>().Subscribe(this.AssetLoadingProgressEventHandler);
        }
        
        public virtual void IntroFinishedEventHandler(IntroFinishedEvent data) {
        }
        
        public virtual void AssetLoadingProgressEventHandler(AssetLoadingProgressEvent data) {
        }
    }
}
