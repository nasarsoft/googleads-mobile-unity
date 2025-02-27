// Copyright (C) 2015 Google, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

namespace GoogleMobileAds.Api
{
    /// <summary>
    /// Describes a reward credited to a user for interacting with rewarded ads.
    /// </summary>
    public class Reward : EventArgs
    {
        /// <summary>
        /// The type of the reward.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The reward amount.
        /// </summary>
        public double Amount { get; set; }
    }
}
