// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrameECSExample {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.ECS.UnityUtilities;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class GrabStartPosition {
        
        public BackgroundScroller Group;
        
        private BackgroundScroller _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        public BackgroundScroller Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.Systems.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual void Execute() {
            // SetVariableNode
            Group.StartPosition = (UnityEngine.Vector3)Group.Entity.transform.position;
        }
    }
}
