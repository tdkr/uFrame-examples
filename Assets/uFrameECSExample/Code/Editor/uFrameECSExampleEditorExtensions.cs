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
    using uFrame.Kernel;
    
    
    [UnityEditor.InitializeOnLoadAttribute()]
    [uFrame.Attributes.uFrameIdentifier("41744c8e-0cac-44ed-bde8-0ef7615bd319")]
    public class uFrameECSExampleEditorExtensions {
        
        [UnityEditor.MenuItem("GameObject/Create uFrameECSExample Kernel", false, 0)]
        public static void AddKernel() {
            uFrame.ECS.Templates.EcsEditorExtensionTemplate.AddEcsKernelWith<uFrameECSExample.uFrameECSExampleLoader>();
        }
    }
}
