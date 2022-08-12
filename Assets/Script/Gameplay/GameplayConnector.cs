using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Me.ContohMVC.Save;
using Me.ContohMVC.Sound;
using Me.ContohMVC.Message;

namespace Me.ContohMVC.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private SaveController _saveData;
        private SFXController _soundfx;
        protected override void Connect()
        {
            Subscribe<UpdateCoinMessage>(OnUpdateCoin);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateCoinMessage>(OnUpdateCoin);
        }
        public void OnUpdateCoin(UpdateCoinMessage message)
        {
            _saveData.OnUpdateCoin(message.Coin);
            _soundfx.OnUpdateCoin();
        }
    }
}


