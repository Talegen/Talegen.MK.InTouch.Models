/*
 *
 * (c) Copyright Talegen, LLC.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/

namespace Talegen.MK.InTouch.Models.Customers
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of customer phone number types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerSocialNetworkType
    {
        /// <summary>
        /// Facebook.
        /// </summary>
        Facebook,

        /// <summary>
        /// Twitter.
        /// </summary>
        Twitter,

        /// <summary>
        /// Instagram.
        /// </summary>
        Instagram,

        /// <summary>
        /// YouTube.
        /// </summary>
        YouTube,

        /// <summary>
        /// Lnkedin.
        /// </summary>
        LinkedIn,

        /// <summary>
        /// Other (Blog, etc.)
        /// </summary>
        Other
    }

    /// <summary>
    /// This class represents a customer social network profile record.
    /// </summary>
    public class CustomerSocialNetwork
    {
        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>The key.</value>
        public Guid Key { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public CustomerSocialNetworkType Type { get; set; } = CustomerSocialNetworkType.Other;

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; set; }
    }
}