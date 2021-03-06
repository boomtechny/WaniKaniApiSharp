﻿using System.Collections.Generic;
using Newtonsoft.Json;
using WaniKaniApi.Converters;

namespace WaniKaniApi.Models
{
    /// <summary>
    /// Response for the recent unlock request.
    /// </summary>
    internal class WaniKaniRecentUnlocksResponse : WaniKaniResponse
    {
        /// <summary>
        /// Gets or sets the recently unlocked items.
        /// </summary>
        [JsonProperty(PropertyName="requested_information")]
        [JsonConverter(typeof(WaniKaniDashboardItemConverter))]
        public List<WaniKaniRecentUnlock> RecentUnlocks { get; set; }
    }
}
