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
    
    
    [uFrame.Attributes.ComponentId(7)]
    [uFrame.Attributes.uFrameIdentifier("a049b201-5934-4098-aa9c-2a00c96dbd14")]
    public partial class SpawnWithRandomX : uFrame.ECS.Components.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Vector2 _XRange;
        
        [UnityEngine.SerializeField()]
        private Single _Z;
        
        [UnityEngine.SerializeField()]
        private Single _Y;
        
        private Subject<PropertyChangedEvent<Vector2>> _XRangeObservable;
        
        private PropertyChangedEvent<Vector2> _XRangeEvent;
        
        private Subject<PropertyChangedEvent<Single>> _ZObservable;
        
        private PropertyChangedEvent<Single> _ZEvent;
        
        private Subject<PropertyChangedEvent<Single>> _YObservable;
        
        private PropertyChangedEvent<Single> _YEvent;
        
        public override int ComponentId {
            get {
                return 7;
            }
        }
        
        public IObservable<PropertyChangedEvent<Vector2>> XRangeObservable {
            get {
                return _XRangeObservable ?? (_XRangeObservable = new Subject<PropertyChangedEvent<Vector2>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> ZObservable {
            get {
                return _ZObservable ?? (_ZObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> YObservable {
            get {
                return _YObservable ?? (_YObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public Vector2 XRange {
            get {
                return _XRange;
            }
            set {
                SetXRange(value);
            }
        }
        
        public Single Z {
            get {
                return _Z;
            }
            set {
                SetZ(value);
            }
        }
        
        public Single Y {
            get {
                return _Y;
            }
            set {
                SetY(value);
            }
        }
        
        public virtual void SetXRange(Vector2 value) {
            SetProperty(ref _XRange, value, ref _XRangeEvent, _XRangeObservable);
        }
        
        public virtual void SetZ(Single value) {
            SetProperty(ref _Z, value, ref _ZEvent, _ZObservable);
        }
        
        public virtual void SetY(Single value) {
            SetProperty(ref _Y, value, ref _YEvent, _YObservable);
        }
    }
}
