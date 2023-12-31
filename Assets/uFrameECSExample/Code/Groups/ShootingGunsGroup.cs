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
    using UniRx;
    
    
    public partial class ShootingGunsGroup : ReactiveGroup<ShootingGuns> {
        
        private IEcsComponentManagerOf<Gun> _GunManager;
        
        private int lastEntityId;
        
        private Gun Gun;
        
        public IEcsComponentManagerOf<Gun> GunManager {
            get {
                return _GunManager;
            }
            set {
                _GunManager = value;
            }
        }
        
        public override System.Collections.Generic.IEnumerable<IObservable<int>> Install(uFrame.ECS.APIs.IComponentSystem componentSystem) {
            componentSystem.PropertyChangedEvent<Gun, GunState>(_ => _.StateObservable, (c, v) => { UpdateItem(c.EntityId); });
            GunManager = componentSystem.RegisterComponent<Gun>();
            yield return GunManager.CreatedObservable.Select(_=>_.EntityId);;
            yield return GunManager.RemovedObservable.Select(_=>_.EntityId);;
        }
        
        public override bool Match(int entityId) {
            lastEntityId = entityId;
            if ((Gun = GunManager[entityId]) == null) {
                return false;
            }
            if (Gun.State==GunState.Shooting) {
                return true;
            }
            else {
                return false;
            }
            return true;
        }
        
        public override ShootingGuns Select() {
            var item = new ShootingGuns();;
            item.EntityId = lastEntityId;
            item.Gun = Gun;
            return item;
        }
    }
}
