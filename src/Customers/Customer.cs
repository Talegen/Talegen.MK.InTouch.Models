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
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of customer email address statuses.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerEmailStatus
    {
        /// <summary>
        /// Email is blocked.
        /// </summary>
        Blocked,

        /// <summary>
        /// Email is valid.
        /// </summary>
        Valid,

        /// <summary>
        /// Email is invalid.
        /// </summary>
        Invalid
    }

    /// <summary>
    /// Contains an enumerated list of customer subscription statuses.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerSubscriptionStatus
    {
        /// <summary>
        /// Opted in
        /// </summary>
        OptedIn,

        /// <summary>
        /// Opted out by consultant.
        /// </summary>
        OptedOutByConsultant,

        /// <summary>
        /// Opted out by customer
        /// </summary>
        OptedOutByCustomer
    }

    /// <summary>
    /// This class represents a customer within the application.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>The customer identifier.</value>
        public Guid CustomerId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the consultant key.
        /// </summary>
        /// <value>The consultant key.</value>
        public Guid ConsultantKey { get; set; }

        /// <summary>
        /// Gets or sets the legacy contact identifier.
        /// </summary>
        /// <value>The legacy contact identifier.</value>
        public string LegacyContactId { get; set; }

        /// <summary>
        /// Gets or sets the image last updated date UTC.
        /// </summary>
        /// <value>The image last updated date UTC.</value>
        public DateTime? ImageLastUpdatedDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the preferred language.
        /// </summary>
        /// <value>The preferred language.</value>
        public string PreferredLanguage { get; set; } = ModelDefaults.DefaultLanguage;

        /// <summary>
        /// Gets or sets a value indicating whether this instance can send SMS to the customer cell phone.
        /// </summary>
        /// <value><c>true</c> if this instance can send SMS to cell; otherwise, <c>false</c>.</value>
        public bool CanSendSMSToCell { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is interested in business opportunity.
        /// </summary>
        /// <value><c>true</c> if this instance is interested in business opportunity; otherwise, <c>false</c>.</value>
        public bool? IsInterestedInBusinessOpportunity { get; set; }

        /// <summary>
        /// Gets or sets the is interested in business opportunity changed UTC.
        /// </summary>
        /// <value>The is interested in business opportunity changed UTC.</value>
        public DateTime? IsInterestedInBusinessOpportunityChangedUtc { get; set; }

        /// <summary>
        /// Gets or sets the mke cards subscription status.
        /// </summary>
        /// <value>The mke cards subscription status.</value>
        public CustomerSubscriptionStatus MkeCardsSubscriptionStatus { get; set; }

        /// <summary>
        /// Gets or sets the profile date UTC.
        /// </summary>
        /// <value>The profile date UTC.</value>
        public DateTime? ProfileDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the name of the middle.
        /// </summary>
        /// <value>The name of the middle.</value>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the employer.
        /// </summary>
        /// <value>The employer.</value>
        public string Employer { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the email status.
        /// </summary>
        /// <value>The email status.</value>
        public CustomerEmailStatus EmailStatus { get; set; }

        /// <summary>
        /// Gets or sets the direct mail is opted out.
        /// </summary>
        /// <value>The direct mail is opted out.</value>
        public bool? DirectMailIsOptedOut { get; set; }

        /// <summary>
        /// Gets or sets the email subscriptions.
        /// </summary>
        /// <value>The email subscriptions.</value>
        public List<CustomerEmailSubscription> EmailSubscriptions { get; set; } = new List<CustomerEmailSubscription>();

        /// <summary>
        /// Gets or sets the primary address.
        /// </summary>
        /// <value>The primary address.</value>
        public CustomerAddress PrimaryAddress { get; set; }

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        /// <value>The addresses.</value>
        public List<CustomerAddress> Addresses { get; set; } = new List<CustomerAddress>();

        /// <summary>
        /// Gets or sets the phone numbers.
        /// </summary>
        /// <value>The phone numbers.</value>
        public List<CustomerPhoneNumber> PhoneNumbers { get; set; } = new List<CustomerPhoneNumber>();

        /// <summary>
        /// Gets or sets the special occasions.
        /// </summary>
        /// <value>The special occasions.</value>
        public List<CustomerSpecialOccasion> SpecialOccasions { get; set; } = new List<CustomerSpecialOccasion>();

        /// <summary>
        /// Gets or sets the date added UTC.
        /// </summary>
        /// <value>The date added UTC.</value>
        public DateTime? DateAddedUtc { get; set; }

        /// <summary>
        /// Gets or sets the date registered UTC.
        /// </summary>
        /// <value>The date registered UTC.</value>
        public DateTime? DateRegisteredUtc { get; set; }

        /// <summary>
        /// Gets or sets the last order date UTC.
        /// </summary>
        /// <value>The last order date UTC.</value>
        public DateTime? LastOrderDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the retinization start date.
        /// </summary>
        /// <value>The retinization start date.</value>
        public DateTime? RetinizationStartDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is deleted.
        /// </summary>
        /// <value><c>true</c> if this instance is deleted; otherwise, <c>false</c>.</value>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is archived.
        /// </summary>
        /// <value><c>true</c> if this instance is archived; otherwise, <c>false</c>.</value>
        public bool IsArchived { get; set; }

        /// <summary>
        /// Gets or sets the is easy ship opted in.
        /// </summary>
        /// <value>The is easy ship opted in.</value>
        public bool? IsEasyShipOptedIn { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is registered for PWS.
        /// </summary>
        /// <value><c>true</c> if this instance is registered for PWS; otherwise, <c>false</c>.</value>
        public bool? IsRegisteredForPws { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is guest.
        /// </summary>
        /// <value><c>true</c> if this instance is guest; otherwise, <c>false</c>.</value>
        public bool IsGuest { get; set; }

        /// <summary>
        /// Gets or sets the spouse.
        /// </summary>
        /// <value>The spouse.</value>
        public CustomerSpouse Spouse { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is purged.
        /// </summary>
        /// <value><c>true</c> if this instance is purged; otherwise, <c>false</c>.</value>
        public bool IsPurged { get; set; }

        /// <summary>
        /// Gets or sets the date deleted UTC.
        /// </summary>
        /// <value>The date deleted UTC.</value>
        public DateTime? DateDeletedUtc { get; set; }

        /// <summary>
        /// Gets or sets the created by client key.
        /// </summary>
        /// <value>The created by client key.</value>
        public string CreatedByClientKey { get; set; }

        /// <summary>
        /// Gets or sets the updated by client key.
        /// </summary>
        /// <value>The updated by client key.</value>
        public string UpdatedByClientKey { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>The tags.</value>
        public List<string> Tags { get; set; } = new List<string>();
    }
}