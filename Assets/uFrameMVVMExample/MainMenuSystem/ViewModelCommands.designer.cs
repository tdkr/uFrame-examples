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
    
    
    public partial class DefaultCommand : uFrame.MVVM.ViewModels.ViewModelCommand {
    }
    
    public partial class ApplyCommand : uFrame.MVVM.ViewModels.ViewModelCommand {
    }
    
    public partial class CloseCommand : uFrame.MVVM.ViewModels.ViewModelCommand {
    }
    
    public partial class SelectLevelCommand : uFrame.MVVM.ViewModels.ViewModelCommand {
        
        private LevelDescriptor _Argument;
        
        public LevelDescriptor Argument {
            get {
                return _Argument;
            }
            set {
                _Argument = value;
            }
        }
    }
    
    public partial class LoginCommand : uFrame.MVVM.ViewModels.ViewModelCommand {
    }
}
