﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteDangerousEvents
{
    public class EnteredSupercruiseEvent : Event
    {
        public const string NAME = "Entered supercruise";
        public const string DESCRIPTION = "Triggered when your ship enters supercruise";
        public static EnteredSupercruiseEvent SAMPLE = new EnteredSupercruiseEvent(DateTime.Now);
        public static Dictionary<string, string> VARIABLES = new Dictionary<string, string>();

        static EnteredSupercruiseEvent()
        {
            SAMPLE.raw = "{\"timestamp\":\"2016-06-10T14:32:03Z\",\"event\":\"SupercruiseEntry\",\"StarSystem\":\"Yuetu\"}";
        }

        public EnteredSupercruiseEvent(DateTime timestamp) : base(timestamp, NAME)
        {
        }
    }
}
