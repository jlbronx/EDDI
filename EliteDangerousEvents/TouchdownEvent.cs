﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteDangerousEvents
{
    public class TouchdownEvent : Event
    {
        public const string NAME = "Touchdown";
        public const string DESCRIPTION = "Triggered when your ship touches down on a planet's surface";
        public static TouchdownEvent SAMPLE = new TouchdownEvent(DateTime.Now, 157.599380M, 63.468872M);
        public static Dictionary<string, string> VARIABLES = new Dictionary<string, string>();

        static TouchdownEvent()
        {
            SAMPLE.raw = "{\"timestamp\":\"2016-07-22T10:38:46Z\",\"event\":\"Touchdown\",\"Latitude\":63.468872,\"Longitude\":157.599380}";

            VARIABLES.Add("longitude", "The longitude from where the commander has touched down");
            VARIABLES.Add("latitude", "The latitude from where the commander has touched down");
        }

        [JsonProperty("longitude")]
        public decimal longitude { get; private set; }

        [JsonProperty("latitude")]
        public decimal latitude { get; private set; }

        public TouchdownEvent(DateTime timestamp, decimal longitude, decimal latitude) : base(timestamp, NAME)
        {
            this.longitude = longitude;
            this.latitude = latitude;
        }
    }
}
