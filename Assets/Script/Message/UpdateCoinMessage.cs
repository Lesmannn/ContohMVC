using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Me.ContohMVC.Message
{
    public struct UpdateCoinMessage
    {
        public int Coin { get; private set; }

        public UpdateCoinMessage(int coin)
        {
            Coin = coin;
        }
    }

}
