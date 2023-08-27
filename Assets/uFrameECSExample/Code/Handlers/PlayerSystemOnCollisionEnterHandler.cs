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
    
    
    public class PlayerSystemOnCollisionEnterHandler {
        
        public Hazard Collider;
        
        public PlayerGunner Source;
        
        private uFrame.ECS.UnityUtilities.OnTriggerEnterDispatcher _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        private UnityEngine.GameObject ActionNode31_gameObject = default( UnityEngine.GameObject );
        
        private float ActionNode31_time = default( System.Single );
        
        public uFrame.ECS.UnityUtilities.OnTriggerEnterDispatcher Event {
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
            ActionNode31_gameObject = Collider.Entity.gameObject;
            // ActionNode
            // Visit uFrame.ECS.Actions.DestroyLibrary.DestroyGameObject
            uFrame.ECS.Actions.DestroyLibrary.DestroyGameObject(ActionNode31_gameObject, ActionNode31_time);
        }
    }
}