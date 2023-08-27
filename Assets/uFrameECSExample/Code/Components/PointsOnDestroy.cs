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
    using uFrame.ECS.Components;
    using uFrame.Json;
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.ComponentId(19)]
    [uFrame.Attributes.uFrameIdentifier("c6c49be3-5c47-475a-9dfb-46899904ee88")]
    public partial class PointsOnDestroy : uFrame.ECS.Components.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Int32 _Points;
        
        private Subject<PropertyChangedEvent<Int32>> _PointsObservable;
        
        private PropertyChangedEvent<Int32> _PointsEvent;
        
        public override int ComponentId {
            get {
                return 19;
            }
        }
        
        public IObservable<PropertyChangedEvent<Int32>> PointsObservable {
            get {
                return _PointsObservable ?? (_PointsObservable = new Subject<PropertyChangedEvent<Int32>>());
            }
        }
        
        public Int32 Points {
            get {
                return _Points;
            }
            set {
                SetPoints(value);
            }
        }
        
        public virtual void SetPoints(Int32 value) {
            SetProperty(ref _Points, value, ref _PointsEvent, _PointsObservable);
        }
    }
}
