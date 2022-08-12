using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;

namespace Me.ContohMVC.Game
{
    public interface IClickGameModel : IBaseModel
    {
        public int Coin { get; }
    }
}
