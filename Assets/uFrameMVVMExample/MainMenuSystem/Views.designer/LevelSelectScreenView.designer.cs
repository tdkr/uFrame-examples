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
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Kernel;
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.MVVM.Services;
    using uFrame.MVVM.ViewModels;
    using UniRx;
    using UnityEngine;
    
    
    public class LevelSelectScreenViewBase : SubScreenView {
        
        [uFrame.MVVM.Attributes.UFToggleGroup("AvailableLevels")]
        [UnityEngine.HideInInspector()]
        public bool _BindAvailableLevels = true;
        
        public override string DefaultIdentifier {
            get {
                return base.DefaultIdentifier;
            }
        }
        
        public override System.Type ViewModelType {
            get {
                return typeof(LevelSelectScreenViewModel);
            }
        }
        
        public LevelSelectScreenViewModel LevelSelectScreen {
            get {
                return (LevelSelectScreenViewModel)ViewModelObject;
            }
        }
        
        protected override void InitializeViewModel(uFrame.MVVM.ViewModels.ViewModel model) {
            base.InitializeViewModel(model);
            // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
            // var vm = model as LevelSelectScreenViewModel;
            // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
        }
        
        public override void Bind() {
            base.Bind();
            // Use this.LevelSelectScreen to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
            if (_BindAvailableLevels) {
                this.BindCollection(this.LevelSelectScreen.AvailableLevels, this.AvailableLevelsOnAdd, this.AvailableLevelsOnRemove);
            }
        }
        
        public virtual void AvailableLevelsOnAdd(LevelDescriptor arg1) {
        }
        
        public virtual void AvailableLevelsOnRemove(LevelDescriptor arg1) {
        }
        
        public virtual void ExecuteSelectLevel(SelectLevelCommand command) {
            command.Sender = LevelSelectScreen;
            LevelSelectScreen.SelectLevel.OnNext(command);
        }
        
        public virtual void ExecuteSelectLevel(LevelDescriptor arg) {
            LevelSelectScreen.SelectLevel.OnNext(new SelectLevelCommand() { Sender = LevelSelectScreen, Argument = arg });
        }
    }
}
