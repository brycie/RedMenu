﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuAPI;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace RedMenuClient
{
    public class MainClient : BaseScript
    {
        public MainClient()
        {
            menus.MainMenu.SetupMenu();
        }

    }
}
