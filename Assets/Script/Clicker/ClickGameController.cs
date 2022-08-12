using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Me.ContohMVC.Game;
using Me.ContohMVC.Save;
using Me.ContohMVC.Message;

namespace Me.ContohMVC.Clicker
{
    public class ClickGameController : ObjectController<ClickGameController, ClickGameModel, IClickGameModel, ClickGameView>
    {
        private SaveController _saveData;
        private void OnClickEarnCoin()
        {
            _model.AddCoin();
            Publish<UpdateCoinMessage>(new UpdateCoinMessage(_model.Coin));
        }

        private void OnClickSpendCoin()
        {
            _model.SubstractCoin();
            Publish<UpdateCoinMessage>(new UpdateCoinMessage(_model.Coin));
        }

        private void OnClickBack()
        {
            SceneLoader.Instance.LoadScene("HomeScene");
        }
        public override void SetView(ClickGameView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnClickEarnCoin, OnClickSpendCoin, OnClickBack);
        }
        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            _model.SetCoin(_saveData.Model.Coin);
        }
    }
}

