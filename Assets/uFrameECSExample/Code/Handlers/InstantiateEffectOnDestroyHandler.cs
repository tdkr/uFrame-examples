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
    
    
    public class EffectOnDestroyComponentDestroyed {
        
        public EffectOnDestroy Group;
        
        private EffectOnDestroy _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        private bool ActionNode1_value = default( System.Boolean );
        
        private UnityEngine.GameObject ActionNode2_gameObject = default( UnityEngine.GameObject );
        
        private UnityEngine.Vector3 ActionNode2_position = default( UnityEngine.Vector3 );
        
        private UnityEngine.Vector3 ActionNode2_rotation = default( UnityEngine.Vector3 );
        
        private UnityEngine.GameObject ActionNode2_Result = default( UnityEngine.GameObject );
        
        public EffectOnDestroy Event {
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
            ActionNode1_value = Group.IsQuiting;
            // ActionNode
            // Visit uFrame.ECS.Actions.Comparisons.IsTrue
            uFrame.ECS.Actions.Comparisons.IsTrue(ActionNode1_value, ActionNode1_yes, ActionNode1_no);
        }
        
        private void ActionNode1_yes() {
        }
        
        private void ActionNode1_no() {
            ActionNode2_gameObject = Group.Prefab;
            ActionNode2_position = Group.Entity.transform.position;
            // ActionNode
            // Visit uFrame.ECS.Actions.GameObjects.Instantiate
            ActionNode2_Result = uFrame.ECS.Actions.GameObjects.Instantiate(ActionNode2_gameObject, ActionNode2_position, ActionNode2_rotation);
        }
    }
}
