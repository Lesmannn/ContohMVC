using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Me.ContohMVC;

namespace Me.ContohMVC.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "GameplayScene";

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}

