using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Me.ContohMVC.HomeScreen
{
    public class HomeView : BaseSceneView
    {
        [SerializeField] private Button _playButton;

        public void SetCallBacks(UnityAction onClickPlayButton)
        {
            _playButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(onClickPlayButton);
        }
    }
}

