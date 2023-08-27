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
    
    
    public partial class WeaponInputSystemBase : uFrame.ECS.Systems.EcsSystem, uFrame.ECS.APIs.ISystemUpdate {
        
        private IEcsComponentManagerOf<ShootingGuns> _ShootingGunsManager;
        
        private IEcsComponentManagerOf<PlayerGunner> _PlayerGunnerManager;
        
        private IEcsComponentManagerOf<Gun> _GunManager;
        
        private IEcsComponentManagerOf<GunnerInput> _GunnerInputManager;
        
        private IEcsComponentManagerOf<Gunner> _GunnerManager;
        
        private GunnerInputUpdateHandler GunnerInputUpdateHandlerInstance = new GunnerInputUpdateHandler();
        
        public IEcsComponentManagerOf<ShootingGuns> ShootingGunsManager {
            get {
                return _ShootingGunsManager;
            }
            set {
                _ShootingGunsManager = value;
            }
        }
        
        public IEcsComponentManagerOf<PlayerGunner> PlayerGunnerManager {
            get {
                return _PlayerGunnerManager;
            }
            set {
                _PlayerGunnerManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Gun> GunManager {
            get {
                return _GunManager;
            }
            set {
                _GunManager = value;
            }
        }
        
        public IEcsComponentManagerOf<GunnerInput> GunnerInputManager {
            get {
                return _GunnerInputManager;
            }
            set {
                _GunnerInputManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Gunner> GunnerManager {
            get {
                return _GunnerManager;
            }
            set {
                _GunnerManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            ShootingGunsManager = ComponentSystem.RegisterGroup<ShootingGunsGroup,ShootingGuns>();
            PlayerGunnerManager = ComponentSystem.RegisterGroup<PlayerGunnerGroup,PlayerGunner>();
            GunManager = ComponentSystem.RegisterComponent<Gun>(2);
            GunnerInputManager = ComponentSystem.RegisterComponent<GunnerInput>(3);
            GunnerManager = ComponentSystem.RegisterComponent<Gunner>(1);
        }
        
        protected virtual void GunnerInputUpdateHandler(PlayerGunner group) {
            var handler = GunnerInputUpdateHandlerInstance;
            handler.System = this;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void GunnerInputUpdateFilter() {
            var PlayerGunnerItems = PlayerGunnerManager.Components;
            for (var PlayerGunnerIndex = 0
            ; PlayerGunnerIndex < PlayerGunnerItems.Count; PlayerGunnerIndex++
            ) {
                if (!PlayerGunnerItems[PlayerGunnerIndex].Enabled) {
                    continue;
                }
                this.GunnerInputUpdateHandler(PlayerGunnerItems[PlayerGunnerIndex]);
            }
        }
        
        public virtual void SystemUpdate() {
            GunnerInputUpdateFilter();
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("184bb774-0dbe-48e2-b211-d4963c809668")]
    public partial class WeaponInputSystem : WeaponInputSystemBase {
        
        private static WeaponInputSystem _Instance;
        
        public WeaponInputSystem() {
            Instance = this;
        }
        
        public static WeaponInputSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}
