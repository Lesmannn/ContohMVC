using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Me.ContohMVC.Save
{
    public interface ISaveModel : IBaseModel
    {
        public int Coin { get; }
    }
}


