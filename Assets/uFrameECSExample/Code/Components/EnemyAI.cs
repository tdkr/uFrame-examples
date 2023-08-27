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
    
    
    [uFrame.Attributes.ComponentId(8)]
    [uFrame.Attributes.uFrameIdentifier("0df03635-9b0d-4617-a36b-5937eeeb2995")]
    public partial class EnemyAI : uFrame.ECS.Components.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Single _CurrentSpeed;
        
        [UnityEngine.SerializeField()]
        private Vector2 _ManeuverTime;
        
        [UnityEngine.SerializeField()]
        private Single _TargetManeuver;
        
        [UnityEngine.SerializeField()]
        private Single _Tilt;
        
        [UnityEngine.SerializeField()]
        private Single _Smoothing;
        
        [UnityEngine.SerializeField()]
        private Single _Dodge;
        
        [UnityEngine.SerializeField()]
        private Vector2 _StartWait;
        
        [UnityEngine.SerializeField()]
        private Vector2 _ManeuverWait;
        
        private Subject<PropertyChangedEvent<Single>> _CurrentSpeedObservable;
        
        private PropertyChangedEvent<Single> _CurrentSpeedEvent;
        
        private Subject<PropertyChangedEvent<Vector2>> _ManeuverTimeObservable;
        
        private PropertyChangedEvent<Vector2> _ManeuverTimeEvent;
        
        private Subject<PropertyChangedEvent<Single>> _TargetManeuverObservable;
        
        private PropertyChangedEvent<Single> _TargetManeuverEvent;
        
        private Subject<PropertyChangedEvent<Single>> _TiltObservable;
        
        private PropertyChangedEvent<Single> _TiltEvent;
        
        private Subject<PropertyChangedEvent<Single>> _SmoothingObservable;
        
        private PropertyChangedEvent<Single> _SmoothingEvent;
        
        private Subject<PropertyChangedEvent<Single>> _DodgeObservable;
        
        private PropertyChangedEvent<Single> _DodgeEvent;
        
        private Subject<PropertyChangedEvent<Vector2>> _StartWaitObservable;
        
        private PropertyChangedEvent<Vector2> _StartWaitEvent;
        
        private Subject<PropertyChangedEvent<Vector2>> _ManeuverWaitObservable;
        
        private PropertyChangedEvent<Vector2> _ManeuverWaitEvent;
        
        public override int ComponentId {
            get {
                return 8;
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> CurrentSpeedObservable {
            get {
                return _CurrentSpeedObservable ?? (_CurrentSpeedObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Vector2>> ManeuverTimeObservable {
            get {
                return _ManeuverTimeObservable ?? (_ManeuverTimeObservable = new Subject<PropertyChangedEvent<Vector2>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> TargetManeuverObservable {
            get {
                return _TargetManeuverObservable ?? (_TargetManeuverObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> TiltObservable {
            get {
                return _TiltObservable ?? (_TiltObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> SmoothingObservable {
            get {
                return _SmoothingObservable ?? (_SmoothingObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> DodgeObservable {
            get {
                return _DodgeObservable ?? (_DodgeObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Vector2>> StartWaitObservable {
            get {
                return _StartWaitObservable ?? (_StartWaitObservable = new Subject<PropertyChangedEvent<Vector2>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Vector2>> ManeuverWaitObservable {
            get {
                return _ManeuverWaitObservable ?? (_ManeuverWaitObservable = new Subject<PropertyChangedEvent<Vector2>>());
            }
        }
        
        public Single CurrentSpeed {
            get {
                return _CurrentSpeed;
            }
            set {
                SetCurrentSpeed(value);
            }
        }
        
        public Vector2 ManeuverTime {
            get {
                return _ManeuverTime;
            }
            set {
                SetManeuverTime(value);
            }
        }
        
        public Single TargetManeuver {
            get {
                return _TargetManeuver;
            }
            set {
                SetTargetManeuver(value);
            }
        }
        
        public Single Tilt {
            get {
                return _Tilt;
            }
            set {
                SetTilt(value);
            }
        }
        
        public Single Smoothing {
            get {
                return _Smoothing;
            }
            set {
                SetSmoothing(value);
            }
        }
        
        public Single Dodge {
            get {
                return _Dodge;
            }
            set {
                SetDodge(value);
            }
        }
        
        public Vector2 StartWait {
            get {
                return _StartWait;
            }
            set {
                SetStartWait(value);
            }
        }
        
        public Vector2 ManeuverWait {
            get {
                return _ManeuverWait;
            }
            set {
                SetManeuverWait(value);
            }
        }
        
        public virtual void SetCurrentSpeed(Single value) {
            SetProperty(ref _CurrentSpeed, value, ref _CurrentSpeedEvent, _CurrentSpeedObservable);
        }
        
        public virtual void SetManeuverTime(Vector2 value) {
            SetProperty(ref _ManeuverTime, value, ref _ManeuverTimeEvent, _ManeuverTimeObservable);
        }
        
        public virtual void SetTargetManeuver(Single value) {
            SetProperty(ref _TargetManeuver, value, ref _TargetManeuverEvent, _TargetManeuverObservable);
        }
        
        public virtual void SetTilt(Single value) {
            SetProperty(ref _Tilt, value, ref _TiltEvent, _TiltObservable);
        }
        
        public virtual void SetSmoothing(Single value) {
            SetProperty(ref _Smoothing, value, ref _SmoothingEvent, _SmoothingObservable);
        }
        
        public virtual void SetDodge(Single value) {
            SetProperty(ref _Dodge, value, ref _DodgeEvent, _DodgeObservable);
        }
        
        public virtual void SetStartWait(Vector2 value) {
            SetProperty(ref _StartWait, value, ref _StartWaitEvent, _StartWaitObservable);
        }
        
        public virtual void SetManeuverWait(Vector2 value) {
            SetProperty(ref _ManeuverWait, value, ref _ManeuverWaitEvent, _ManeuverWaitObservable);
        }
    }
}
