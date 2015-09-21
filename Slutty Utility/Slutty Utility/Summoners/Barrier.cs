﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;

namespace Slutty_Utility.Summoners
{
    class Barrier : Helper
    {
        public Barrier()
        {
            Game.OnUpdate += OnUpdate;
        }

        private static void OnUpdate(EventArgs args)
        {
            if (Player.GetSpellSlot("summonerbarrier").IsReady() && Player.CountEnemiesInRange(1400) >= 1)
            {
                if (!HealthCheck("BarrierHealthCheck")) return;
                Player.Spellbook.CastSpell(Player.GetSpellSlot("summonerbarrier"));
            }
        }
    }
}