﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public class VolunAbsorbOnStopHandler : AbsorbFxOnStopHandler
    {
        public override void OnParticleSystemStopped()
        {
            _runtimeAmulet.OnEnemyAIKilled_BlinkVolunAmulet();
            gameObject.SetActive(false);
        }
    }
}