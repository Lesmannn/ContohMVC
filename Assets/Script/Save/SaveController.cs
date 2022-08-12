using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Me.ContohMVC.Save
{
    public class SaveController : DataController<SaveController, SaveModel, ISaveModel>
    {
        private void SaveData()
        {
            PlayerPrefs.SetInt("Coin", _model.Coin);
            PlayerPrefs.Save();
        }

        private void LoadData()
        {
            int coin = PlayerPrefs.GetInt("Coin");
            _model.SetDataCoin(coin);
        }
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            LoadData();
        }
        public void OnUpdateCoin(int coin)
        {
            _model.SetDataCoin(coin);
            SaveData();
        }
    }
}

