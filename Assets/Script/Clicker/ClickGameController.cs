using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Me.ContohMVC.Game;

namespace Me.ContohMVC.Clicker
{
    public class ClickGameController : ObjectController<ClickGameController, ClickGameModel, IClickGameModel, ClickGameView>
    {
        private void OnClickEarnCoin()
        {
            _model.AddCoin();
        }

        private void OnClickSpendCoin()
        {
            _model.SubstractCoin();
        }

        private void OnClickBack()
        {
            SceneLoader.Instance.LoadScene("Home");
        }
        public override void SetView(ClickGameView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnClickEarnCoin, OnClickSpendCoin, OnClickBack);
        }
    }
}

