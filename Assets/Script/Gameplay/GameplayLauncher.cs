using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Me.ContohMVC;
using Me.ContohMVC.Clicker;
using Me.ContohMVC.Sound;

namespace Me.ContohMVC.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        private ClickGameController _clickGame;
        public override string SceneName => "GameplayScene";

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                new GameplayConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new ClickGameController(),
                new SFXController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _clickGame.SetView(_view.ClickGameView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}

