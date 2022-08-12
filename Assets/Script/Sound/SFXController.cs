using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Me.ContohMVC.Sound
{
    public class SFXController : BaseController<SFXController>
    {
        public void OnUpdateCoin()
        {
            Debug.Log("Play Sound fx");
        }

    }
}

