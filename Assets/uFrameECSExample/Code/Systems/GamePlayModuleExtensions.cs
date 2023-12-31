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
    
    
    #region 
static
    public class GamePlayModuleExtensions {
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<PlayGameButton> PlayGameButtonManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<PlayGameButton>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<WavesGame> WavesGameManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<WavesGame>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<GameOverOnCollision> GameOverOnCollisionManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<GameOverOnCollision>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<ScoreText> ScoreTextManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<ScoreText>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<PointsOnDestroy> PointsOnDestroyManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<PointsOnDestroy>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<SpawnMultipleAtInterval> SpawnMultipleAtIntervalManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<SpawnMultipleAtInterval>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<MenuUI> MenuUIManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MenuUI>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.APIs.IEcsComponentManagerOf<SpawnAtInterval> SpawnAtIntervalManager(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<SpawnAtInterval>();
        }
        #endregion
        
        #region 
static
        public List<PlayGameButton> PlayGameButtonComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<PlayGameButton>().Components;
        }
        #endregion
        
        #region 
static
        public List<WavesGame> WavesGameComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<WavesGame>().Components;
        }
        #endregion
        
        #region 
static
        public List<GameOverOnCollision> GameOverOnCollisionComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<GameOverOnCollision>().Components;
        }
        #endregion
        
        #region 
static
        public List<ScoreText> ScoreTextComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<ScoreText>().Components;
        }
        #endregion
        
        #region 
static
        public List<PointsOnDestroy> PointsOnDestroyComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<PointsOnDestroy>().Components;
        }
        #endregion
        
        #region 
static
        public List<SpawnMultipleAtInterval> SpawnMultipleAtIntervalComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<SpawnMultipleAtInterval>().Components;
        }
        #endregion
        
        #region 
static
        public List<MenuUI> MenuUIComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MenuUI>().Components;
        }
        #endregion
        
        #region 
static
        public List<SpawnAtInterval> SpawnAtIntervalComponents(this uFrame.ECS.APIs.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<SpawnAtInterval>().Components;
        }
        #endregion
    }
    #endregion
}
