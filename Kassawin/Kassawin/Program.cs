﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp.Common;

namespace Kassawin
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CustomEvents.Game.OnGameLoad += Kassadin.OnLoad;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("An Error Has Occured {0}", ex);
            }
        }
    }
}
