﻿using OkayegTeaTimeCSharp.Properties;
using System.Collections.Generic;
using System.Linq;

namespace OkayegTeaTimeCSharp.Twitch
{
    public static class Config
    {
        public static List<string> GetChannels()
        {
            return Resources.Channels.Split(" ").ToList();
        }
    }
}
