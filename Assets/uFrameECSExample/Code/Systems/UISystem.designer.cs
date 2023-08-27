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
    
    
    public partial class UISystemBase : uFrame.ECS.Systems.EcsSystem {
        
        private IEcsComponentManagerOf<SpawnAtInterval> _SpawnAtIntervalManager;
        
        private IEcsComponentManagerOf<WavesGame> _WavesGameManager;
        
        private IEcsComponentManagerOf<SpawnMultipleAtInterval> _SpawnMultipleAtIntervalManager;
        
        private IEcsComponentManagerOf<PointsOnDestroy> _PointsOnDestroyManager;
        
        private IEcsComponentManagerOf<PlayGameButton> _PlayGameButtonManager;
        
        private IEcsComponentManagerOf<GameOverOnCollision> _GameOverOnCollisionManager;
        
        private IEcsComponentManagerOf<ScoreText> _ScoreTextManager;
        
        private IEcsComponentManagerOf<MenuUI> _MenuUIManager;
        
        private WavesGameComponentDestroyed WavesGameComponentDestroyedInstance = new WavesGameComponentDestroyed();
        
        private SetScoreLabel SetScoreLabelInstance = new SetScoreLabel();
        
        private UISystemPointerClickDispatcherHandler UISystemPointerClickDispatcherHandlerInstance = new UISystemPointerClickDispatcherHandler();
        
        private DisableUI DisableUIInstance = new DisableUI();
        
        public IEcsComponentManagerOf<SpawnAtInterval> SpawnAtIntervalManager {
            get {
                return _SpawnAtIntervalManager;
            }
            set {
                _SpawnAtIntervalManager = value;
            }
        }
        
        public IEcsComponentManagerOf<WavesGame> WavesGameManager {
            get {
                return _WavesGameManager;
            }
            set {
                _WavesGameManager = value;
            }
        }
        
        public IEcsComponentManagerOf<SpawnMultipleAtInterval> SpawnMultipleAtIntervalManager {
            get {
                return _SpawnMultipleAtIntervalManager;
            }
            set {
                _SpawnMultipleAtIntervalManager = value;
            }
        }
        
        public IEcsComponentManagerOf<PointsOnDestroy> PointsOnDestroyManager {
            get {
                return _PointsOnDestroyManager;
            }
            set {
                _PointsOnDestroyManager = value;
            }
        }
        
        public IEcsComponentManagerOf<PlayGameButton> PlayGameButtonManager {
            get {
                return _PlayGameButtonManager;
            }
            set {
                _PlayGameButtonManager = value;
            }
        }
        
        public IEcsComponentManagerOf<GameOverOnCollision> GameOverOnCollisionManager {
            get {
                return _GameOverOnCollisionManager;
            }
            set {
                _GameOverOnCollisionManager = value;
            }
        }
        
        public IEcsComponentManagerOf<ScoreText> ScoreTextManager {
            get {
                return _ScoreTextManager;
            }
            set {
                _ScoreTextManager = value;
            }
        }
        
        public IEcsComponentManagerOf<MenuUI> MenuUIManager {
            get {
                return _MenuUIManager;
            }
            set {
                _MenuUIManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            SpawnAtIntervalManager = ComponentSystem.RegisterComponent<SpawnAtInterval>(16);
            WavesGameManager = ComponentSystem.RegisterComponent<WavesGame>(15);
            SpawnMultipleAtIntervalManager = ComponentSystem.RegisterComponent<SpawnMultipleAtInterval>(20);
            PointsOnDestroyManager = ComponentSystem.RegisterComponent<PointsOnDestroy>(19);
            PlayGameButtonManager = ComponentSystem.RegisterComponent<PlayGameButton>(18);
            GameOverOnCollisionManager = ComponentSystem.RegisterComponent<GameOverOnCollision>(21);
            ScoreTextManager = ComponentSystem.RegisterComponent<ScoreText>(14);
            MenuUIManager = ComponentSystem.RegisterComponent<MenuUI>(17);
            WavesGameManager.RemovedObservable.Subscribe(_=>WavesGameComponentDestroyed(_,_)).DisposeWith(this);
            this.PropertyChangedEvent<WavesGame,System.Int32>(Group=>Group.ScoreObservable, SetScoreLabelFilter, Group=>Group.Score, false);
            this.OnEvent<uFrame.ECS.UnityUtilities.PointerClickDispatcher>().Subscribe(_=>{ UISystemPointerClickDispatcherFilter(_); }).DisposeWith(this);
            WavesGameManager.CreatedObservable.Subscribe(DisableUIFilter).DisposeWith(this);
        }
        
        protected virtual void WavesGameComponentDestroyed(WavesGame data, WavesGame group) {
            var handler = WavesGameComponentDestroyedInstance;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void WavesGameComponentDestroyedFilter(WavesGame data) {
            var GroupWavesGame = WavesGameManager[data.EntityId];
            if (GroupWavesGame == null) {
                return;
            }
            if (!GroupWavesGame.Enabled) {
                return;
            }
            this.WavesGameComponentDestroyed(data, GroupWavesGame);
        }
        
        protected virtual void SetScoreLabel(WavesGame data, WavesGame group, PropertyChangedEvent<System.Int32> value) {
            var handler = SetScoreLabelInstance;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.OldValue = value.PreviousValue;
            handler.NewValue = value.CurrentValue;
            handler.Execute();
        }
        
        protected void SetScoreLabelFilter(WavesGame data, PropertyChangedEvent<System.Int32> value) {
            var GroupWavesGame = WavesGameManager[data.EntityId];
            if (GroupWavesGame == null) {
                return;
            }
            if (!GroupWavesGame.Enabled) {
                return;
            }
            this.SetScoreLabel(data, GroupWavesGame, value);
        }
        
        protected virtual void UISystemPointerClickDispatcherHandler(uFrame.ECS.UnityUtilities.PointerClickDispatcher data, PlayGameButton source) {
            var handler = UISystemPointerClickDispatcherHandlerInstance;
            handler.System = this;
            handler.Event = data;
            handler.Source = source;
            handler.Execute();
        }
        
        protected void UISystemPointerClickDispatcherFilter(uFrame.ECS.UnityUtilities.PointerClickDispatcher data) {
            var SourcePlayGameButton = PlayGameButtonManager[data.EntityId];
            if (SourcePlayGameButton == null) {
                return;
            }
            if (!SourcePlayGameButton.Enabled) {
                return;
            }
            this.UISystemPointerClickDispatcherHandler(data, SourcePlayGameButton);
        }
        
        protected virtual void DisableUI(WavesGame data, WavesGame group) {
            var handler = DisableUIInstance;
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void DisableUIFilter(WavesGame data) {
            var GroupWavesGame = WavesGameManager[data.EntityId];
            if (GroupWavesGame == null) {
                return;
            }
            if (!GroupWavesGame.Enabled) {
                return;
            }
            this.DisableUI(data, GroupWavesGame);
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("a498a55a-a151-4c36-bfa1-0346d9a5eef4")]
    public partial class UISystem : UISystemBase {
        
        private static UISystem _Instance;
        
        public UISystem() {
            Instance = this;
        }
        
        public static UISystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}
