using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Me.ContohMVC.Save
{
    public class SaveModel : BaseModel, ISaveModel
    {
        public int Coin { get; private set; }

        public void SetDataCoin(int coin)
        {
            Coin = coin;
            SetDataAsDirty();
        }
    }
}

