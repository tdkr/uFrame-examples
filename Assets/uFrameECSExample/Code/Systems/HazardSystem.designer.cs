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
    
    
    public partial class HazardSystemBase : uFrame.ECS.Systems.EcsSystem {
        
        private IEcsComponentManagerOf<EnemyAI> _EnemyAIManager;
        
        private IEcsComponentManagerOf<RandomRotation> _RandomRotationManager;
        
        private IEcsComponentManagerOf<SpawnWithRandomX> _SpawnWithRandomXManager;
        
        private IEcsComponentManagerOf<Projectile> _ProjectileManager;
        
        private IEcsComponentManagerOf<DestroyOnCollision> _DestroyOnCollisionManager;
        
        private IEcsComponentManagerOf<Hazard> _HazardManager;
        
        private HandleDestroyOnCollisionHandler HandleDestroyOnCollisionHandlerInstance = new HandleDestroyOnCollisionHandler();
        
        private BeginRandomRotation BeginRandomRotationInstance = new BeginRandomRotation();
        
        private SetRandomPosition SetRandomPositionInstance = new SetRandomPosition();
        
        private ProjectileCreated ProjectileCreatedInstance = new ProjectileCreated();
        
        public IEcsComponentManagerOf<EnemyAI> EnemyAIManager {
            get {
                return _EnemyAIManager;
            }
            set {
                _EnemyAIManager = value;
            }
        }
        
        public IEcsComponentManagerOf<RandomRotation> RandomRotationManager {
            get {
                return _RandomRotationManager;
            }
            set {
                _RandomRotationManager = value;
            }
        }
        
        public IEcsComponentManagerOf<SpawnWithRandomX> SpawnWithRandomXManager {
            get {
                return _SpawnWithRandomXManager;
            }
            set {
                _SpawnWithRandomXManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Projectile> ProjectileManager {
            get {
                return _ProjectileManager;
            }
            set {
                _ProjectileManager = value;
            }
        }
        
        public IEcsComponentManagerOf<DestroyOnCollision> DestroyOnCollisionManager {
            get {
                return _DestroyOnCollisionManager;
            }
            set {
                _DestroyOnCollisionManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Hazard> HazardManager {
            get {
                return _HazardManager;
            }
            set {
                _HazardManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            EnemyAIManager = ComponentSystem.RegisterComponent<EnemyAI>(8);
            RandomRotationManager = ComponentSystem.RegisterComponent<RandomRotation>(10);
            SpawnWithRandomXManager = ComponentSystem.RegisterComponent<SpawnWithRandomX>(7);
            ProjectileManager = ComponentSystem.RegisterComponent<Projectile>(11);
            DestroyOnCollisionManager = ComponentSystem.RegisterComponent<DestroyOnCollision>(12);
            HazardManager = ComponentSystem.RegisterComponent<Hazard>(9);
            this.OnEvent<uFrame.ECS.UnityUtilities.OnTriggerEnterDispatcher>().Subscribe(_=>{ HandleDestroyOnCollisionFilter(_); }).DisposeWith(this);
            this.OnEvent<uFrame.ECS.UnityUtilities.OnCollisionEnterDispatcher>().Subscribe(_=>{ HazardSystemOnCollisionEnterDispatcherFilter(_); }).DisposeWith(this);
            RandomRotationManager.CreatedObservable.Subscribe(BeginRandomRotationFilter).DisposeWith(this);
            SpawnWithRandomXManager.CreatedObservable.Subscribe(SetRandomPositionFilter).DisposeWith(this);
            ProjectileManager.CreatedObservable.Subscribe(ProjectileCreatedFilter).DisposeWith(this);
        }
        
        protected virtual void HandleDestroyOnCollisionHandler(uFrame.ECS.UnityUtilities.OnTriggerEnterDispatcher data, DestroyOnCollision source) {
            var handler = HandleDestroyOnCollisionHandlerInstance;
            handler.System = this;
            handler.Event = data;
            handler.Source = source;
            handler.Execute();
        }
        
        protected void HandleDestroyOnCollisionFilter(uFrame.ECS.UnityUtilities.OnTriggerEnterDispatcher data) {
            var SourceDestroyOnCollision = DestroyOnCollisionManager[data.EntityId];
            if (SourceDestroyOnCollision == null) {
                return;
            }
            if (!SourceDestroyOnCollision.Enabled) {
                return;
            }
            this.HandleDestroyOnCollisionHandler(data, SourceDestroyOnCollision);
        }
        
        protected virtual void HazardSystemOnCollisionEnterDispatcherHandler(uFrame.ECS.UnityUtilities.OnCollisionEnterDispatcher data, DestroyOnCollision source) {
        }
        
        protected void HazardSystemOnCollisionEnterDispatcherFilter(uFrame.ECS.UnityUtilities.OnCollisionEnterDispatcher data) {
            var SourceDestroyOnCollision = DestroyOnCollisionManager[data.EntityId];
            if (SourceDestroyOnCollision == null) {
                return;
            }
            if (!SourceDestroyOnCollision.Enabled) {
                return;
            }
            this.HazardSystemOnCollisionEnterDispatcherHandler(data, SourceDestroyOnCollision);
        }
        
        protected virtual void BeginRandomRotation(RandomRotation data, RandomRotation group) {
            var handler = BeginRandomRotationInstance;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void BeginRandomRotationFilter(RandomRotation data) {
            var GroupRandomRotation = RandomRotationManager[data.EntityId];
            if (GroupRandomRotation == null) {
                return;
            }
            if (!GroupRandomRotation.Enabled) {
                return;
            }
            this.BeginRandomRotation(data, GroupRandomRotation);
        }
        
        protected virtual void SetRandomPosition(SpawnWithRandomX data, SpawnWithRandomX group) {
            var handler = SetRandomPositionInstance;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void SetRandomPositionFilter(SpawnWithRandomX data) {
            var GroupSpawnWithRandomX = SpawnWithRandomXManager[data.EntityId];
            if (GroupSpawnWithRandomX == null) {
                return;
            }
            if (!GroupSpawnWithRandomX.Enabled) {
                return;
            }
            this.SetRandomPosition(data, GroupSpawnWithRandomX);
        }
        
        protected virtual void ProjectileCreated(Projectile data, Projectile group) {
            var handler = ProjectileCreatedInstance;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void ProjectileCreatedFilter(Projectile data) {
            var GroupProjectile = ProjectileManager[data.EntityId];
            if (GroupProjectile == null) {
                return;
            }
            if (!GroupProjectile.Enabled) {
                return;
            }
            this.ProjectileCreated(data, GroupProjectile);
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("2ad47eef-79a7-4e27-88fb-6740ad9e958a")]
    public partial class HazardSystem : HazardSystemBase {
        
        private static HazardSystem _Instance;
        
        public HazardSystem() {
            Instance = this;
        }
        
        public static HazardSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}
