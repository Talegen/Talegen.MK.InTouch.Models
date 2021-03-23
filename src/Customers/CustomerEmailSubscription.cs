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
    /// Contains an enumerated list of email subscription types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerEmailSubscriptionType
    {
        /// <summary>
        /// The Beauty News.
        /// </summary>
        BeautENews,

        /// <summary>
        /// MK Ecards.
        /// </summary>
        MkeCards,

        /// <summary>
        /// Product reorder reminders.
        /// </summary>
        ProductReorderReminder
    }

    /// <summary>
    /// This class represents a customer email subscription.
    /// </summary>
    public class CustomerEmailSubscription
    {
        /// <summary>
        /// Gets or sets the subscription key.
        /// </summary>
        /// <value>The subscription key.</value>
        public Guid SubscriptionKey { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>The customer identifier.</value>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the consultant key.
        /// </summary>
        /// <value>The consultant key.</value>
        public Guid ConsultantKey { get; set; }

        /// <summary>
        /// Gets or sets the type of the subscription.
        /// </summary>
        /// <value>The type of the subscription.</value>
        public CustomerEmailSubscriptionType SubscriptionType { get; set; }

        /// <summary>
        /// Gets or sets the registration date UTC.
        /// </summary>
        /// <value>The registration date UTC.</value>
        public DateTime? RegistrationDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the subscription status.
        /// </summary>
        /// <value>The subscription status.</value>
        public CustomerSubscriptionStatus SubscriptionStatus { get; set; }

        /// <summary>
        /// Gets or sets the subscribed culture.
        /// </summary>
        /// <value>The subscribed culture.</value>
        public string SubscribedCulture { get; set; } = ModelDefaults.DefaultLanguage;

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>The email address.</value>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is corporate subscription.
        /// </summary>
        /// <value><c>true</c> if this instance is corporate subscription; otherwise, <c>false</c>.</value>
        public bool IsCorporateSubscription { get; set; }
    }
}