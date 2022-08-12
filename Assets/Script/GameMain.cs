using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine.EventSystems;
using Me.ContohMVC.HomeScreen;
using Me.ContohMVC.Gameplay;
using Me.ContohMVC.Save;

namespace Me.ContohMVC
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return null;
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]{
                new SaveController()
            };
        }

        protected override IEnumerator StartInit()
        {
            CreateEventSystem();
            yield return null;
        }

        private void CreateEventSystem()
        {
            GameObject GO = new GameObject("Event System");
            GO.AddComponent<EventSystem>();
            GO.AddComponent<StandaloneInputModule>();
            GameObject.DontDestroyOnLoad(GO);
        }
    }
}

