using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Me.ContohMVC.Game;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Me.ContohMVC.Clicker
{
    public class ClickGameView : ObjectView<IClickGameModel>
    {
        [SerializeField]
        private Text _coinText;
        [SerializeField]
        private Button _earnCoinButton;
        [SerializeField]
        private Button _spendCoinButton;
        [SerializeField]
        private Button _backButton;
        protected override void InitRenderModel(IClickGameModel model)
        {
            _coinText.text = $"Coin: {model.Coin.ToString()}";
        }

        protected override void UpdateRenderModel(IClickGameModel model)
        {
            _coinText.text = $"Coin: {model.Coin.ToString()}";
        }
        public void SetCallbacks(UnityAction onClickEarnCoin, UnityAction onClickSpendCoin, UnityAction onClickBack)
        {
            _earnCoinButton.onClick.RemoveAllListeners();
            _spendCoinButton.onClick.RemoveAllListeners();
            _backButton.onClick.RemoveAllListeners();
            _earnCoinButton.onClick.AddListener(onClickEarnCoin);
            _spendCoinButton.onClick.AddListener(onClickSpendCoin);
            _backButton.onClick.AddListener(onClickBack);
        }
    }
}
