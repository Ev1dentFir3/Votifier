﻿using Rocket;
using Rocket.RocketAPI;
using SDG;
using System;
using System.Collections.Generic;
using System.Linq;

namespace unturned.ROCKS.Votifier
{
    class CommandReward : Command
    {
        public CommandReward()
        {
            base.commandName = "reward";
            base.commandHelp = "Get rewards for voting";
            base.commandInfo = base.commandName + " - " + base.commandHelp;
        }

        protected override void execute(SteamPlayerID caller, string command)
        {
            Votifier.Vote(caller.CSteamID);
        }
    }
}
