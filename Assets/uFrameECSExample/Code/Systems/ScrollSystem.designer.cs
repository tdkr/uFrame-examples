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
    using uFrame.ECS.APIs;
    using uFrame.ECS.Components;
    using uFrame.ECS.Systems;
    using uFrame.Kernel;
    using uFrameECSExample;
    using UniRx;
    using UnityEngine;
    
    
    public partial class ScrollSystemBase : uFrame.ECS.Systems.EcsSystem, uFrame.ECS.APIs.ISystemUpdate {
        
        private IEcsComponentManagerOf<BackgroundScroller> _BackgroundScrollerManager;
        
        private ScrollSystemUpdateHandler ScrollSystemUpdateHandlerInstance = new ScrollSystemUpdateHandler();
        
        private GrabStartPosition GrabStartPositionInstance = new GrabStartPosition();
        
        public IEcsComponentManagerOf<BackgroundScroller> BackgroundScrollerManager {
            get {
                return _BackgroundScrollerManager;
            }
            set {
                _BackgroundScrollerManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            BackgroundScrollerManager = ComponentSystem.RegisterComponent<BackgroundScroller>(6);
            BackgroundScrollerManager.CreatedObservable.Subscribe(GrabStartPositionFilter).DisposeWith(this);
        }
        
        protected virtual void ScrollSystemUpdateHandler(BackgroundScroller group) {
            var handler = ScrollSystemUpdateHandlerInstance;
            handler.System = this;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void ScrollSystemUpdateFilter() {
            var BackgroundScrollerItems = BackgroundScrollerManager.Components;
            for (var BackgroundScrollerIndex = 0
            ; BackgroundScrollerIndex < BackgroundScrollerItems.Count; BackgroundScrollerIndex++
            ) {
                if (!BackgroundScrollerItems[BackgroundScrollerIndex].Enabled) {
                    continue;
                }
                this.ScrollSystemUpdateHandler(BackgroundScrollerItems[BackgroundScrollerIndex]);
            }
        }
        
        public virtual void SystemUpdate() {
            ScrollSystemUpdateFilter();
        }
        
        protected virtual void GrabStartPosition(BackgroundScroller data, BackgroundScroller group) {
            var handler = GrabStartPositionInstance;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void GrabStartPositionFilter(BackgroundScroller data) {
            var GroupBackgroundScroller = BackgroundScrollerManager[data.EntityId];
            if (GroupBackgroundScroller == null) {
                return;
            }
            if (!GroupBackgroundScroller.Enabled) {
                return;
            }
            this.GrabStartPosition(data, GroupBackgroundScroller);
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("14784356-ffc5-46f5-9cca-7bc1da6e3223")]
    public partial class ScrollSystem : ScrollSystemBase {
        
        private static ScrollSystem _Instance;
        
        public ScrollSystem() {
            Instance = this;
        }
        
        public static ScrollSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}