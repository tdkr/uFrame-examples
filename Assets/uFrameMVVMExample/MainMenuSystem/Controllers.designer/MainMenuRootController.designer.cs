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
    
    
    public class MainMenuRootControllerBase : uFrame.MVVM.Controller {
        
        private uFrame.MVVM.ViewModels.IViewModelManager _MainMenuRootViewModelManager;
        
        private MainMenuRootViewModel _MainMenuRoot;
        
        [uFrame.IOC.InjectAttribute("MainMenuRoot")]
        public uFrame.MVVM.ViewModels.IViewModelManager MainMenuRootViewModelManager {
            get {
                return _MainMenuRootViewModelManager;
            }
            set {
                _MainMenuRootViewModelManager = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("MainMenuRoot")]
        public MainMenuRootViewModel MainMenuRoot {
            get {
                return _MainMenuRoot;
            }
            set {
                _MainMenuRoot = value;
            }
        }
        
        public IEnumerable<MainMenuRootViewModel> MainMenuRootViewModels {
            get {
                return MainMenuRootViewModelManager.OfType<MainMenuRootViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeMainMenuRoot(((MainMenuRootViewModel)(viewModel)));
        }
        
        public virtual MainMenuRootViewModel CreateMainMenuRoot() {
            return ((MainMenuRootViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModels.ViewModel CreateEmpty() {
            return new MainMenuRootViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeMainMenuRoot(MainMenuRootViewModel viewModel) {
            // This is called when a MainMenuRootViewModel is created
            MainMenuRootViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            MainMenuRootViewModelManager.Remove(viewModel);
        }
    }
}
