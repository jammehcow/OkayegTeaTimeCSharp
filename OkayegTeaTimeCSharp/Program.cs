﻿using OkayegTeaTimeCSharp.Git;
using OkayegTeaTimeCSharp.JsonData;
using OkayegTeaTimeCSharp.Twitch.Bot;
using OkayegTeaTimeCSharp.Utils;
using System;

namespace OkayegTeaTimeCSharp
{
    public abstract class Program
    {
        private static void Main(string[] args)
        {
            JsonHelper.SetData();
            ReadMeGenerator.GenerateReadMe();
            PrefixHelper.FillDictionary();
            BotHelper.FillLastMessagesDictionary();

            TwitchBot OkayegTeaTime = new();
            OkayegTeaTime.SetBot();

            //TwitchAPI twitchAPI = new();

            Console.ReadLine();
        }
    }
}

#warning needs a list of channels in which the bot is not allowed to send massages
#warning remove emote and user count from counteg doc
#warning get channels from database not from resources
#warning cmd type const missing in some cmd classes
#warning change prefixstring column to varbinary to support emojis
