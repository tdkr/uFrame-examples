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
    
    
    public class SetRandomPosition {
        
        public SpawnWithRandomX Group;
        
        private SpawnWithRandomX _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        private float ActionNode13_minX = default( System.Single );
        
        private float ActionNode13_maxX = default( System.Single );
        
        private float ActionNode13_minY = default( System.Single );
        
        private float ActionNode13_maxY = default( System.Single );
        
        private float ActionNode13_minZ = default( System.Single );
        
        private float ActionNode13_maxZ = default( System.Single );
        
        private UnityEngine.Vector3 ActionNode13_Result = default( UnityEngine.Vector3 );
        
        public SpawnWithRandomX Event {
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
            ActionNode13_minX = Group.XRange.x;
            ActionNode13_maxX = Group.XRange.y;
            ActionNode13_minY = Group.Y;
            ActionNode13_maxY = Group.Y;
            ActionNode13_minZ = Group.Z;
            ActionNode13_maxZ = Group.Z;
            // ActionNode
            // Visit uFrame.ECS.Actions.CreateRandoms.RandomVector3
            ActionNode13_Result = uFrame.ECS.Actions.CreateRandoms.RandomVector3(ActionNode13_minX, ActionNode13_maxX, ActionNode13_minY, ActionNode13_maxY, ActionNode13_minZ, ActionNode13_maxZ);
            // SetVariableNode
            Group.Entity.transform.position = (UnityEngine.Vector3)ActionNode13_Result;
        }
    }
}
