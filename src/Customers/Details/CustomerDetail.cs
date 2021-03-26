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

namespace Talegen.MK.InTouch.Models.Customers.Details
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Serialization;

    /// <summary>
    /// Contains an enumerated list of customer preferred contact times.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerContactTimes
    {
        /// <summary>
        /// Contact time in the AM.
        /// </summary>
        AM,

        /// <summary>
        /// Contact time in the PM.
        /// </summary>
        PM
    }

    /// <summary>
    /// Contains an enumerated list of customer preferred contact methods.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerContactMethods
    {
        /// <summary>
        /// Contact customer via e-mail.
        /// </summary>
        Email,

        /// <summary>
        /// Contact customer via phone call.
        /// </summary>
        Phone
    }

    /// <summary>
    /// Contains an enumerated list of customer preferred contact frequencies.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerContactFrequencies
    {
        /// <summary>
        /// Contact monthly.
        /// </summary>
        Monthly,

        /// <summary>
        /// Contact every two months.
        /// </summary>
        EveryTwoMonths,

        /// <summary>
        /// Contact every three months.
        /// </summary>
        EveryThreeMonths,

        /// <summary>
        /// Contact when new products are available.
        /// </summary>
        WhenNewProductsAreAvailable,

        /// <summary>
        /// Contact only when I am ready.
        /// </summary>
        OnlyWhenIAmReady
    }

    /// <summary>
    /// Contains an enumerated list of biological genders.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerGender
    {
        /// <summary>
        /// Customer is male.
        /// </summary>
        Male,

        /// <summary>
        /// Customer is female.
        /// </summary>
        Female
    }

    /// <summary>
    /// Contains an enumerated list of topics of interest.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerLearningTopicsOfInterestTypes
    {
        /// <summary>
        /// Additional skin care options.
        /// </summary>
        AdditionalSkinCareOptions,

        /// <summary>
        /// Fragrance Body Care.
        /// </summary>
        FragranceBodyCare,

        /// <summary>
        /// Color Application Techniques.
        /// </summary>
        ColorApplicationTechniques,

        /// <summary>
        /// Mens Products.
        /// </summary>
        MensProducts,

        /// <summary>
        /// Gift Giving Services.
        /// </summary>
        GiftGivingServices,

        /// <summary>
        /// Earning Extra Money.
        /// </summary>
        EarningExtraMoney
    }

    /// <summary>
    /// Defines an enumerate list of customer shopping methods.
    /// </summary>
    public enum CustomerShoppingMethods
    {
        /// <summary>
        /// Shop at Party.
        /// </summary>
        Party,

        /// <summary>
        /// Shop Online.
        /// </summary>
        Online,

        /// <summary>
        /// Shop Phone.
        /// </summary>
        Phone
    }

    /// <summary>
    /// This class represents the customer details record returned from the In Touch API.
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CustomerDetail : CustomerBase
    {
        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>The email address.</value>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the occupation.
        /// </summary>
        /// <value>The occupation.</value>
        public string Occupation { get; set; }

        /// <summary>
        /// Gets or sets a list of preferred contact methods.
        /// </summary>
        public List<CustomerContactMethods> PreferredContactMethods { get; set; } = new List<CustomerContactMethods>();

        /// <summary>
        /// Gets or sets a list of preferred contact times.
        /// </summary>
        public List<CustomerContactTimes> PreferredContactTimes { get; set; } = new List<CustomerContactTimes>();

        /// <summary>
        /// Gets or sets a list of preferred contact frequencies.
        /// </summary>
        public List<CustomerContactFrequencies> PreferredContactFrequencies { get; set; } = new List<CustomerContactFrequencies>();

        /// <summary>
        /// Gets or sets a list of preferred contact days.
        /// </summary>
        /// <remarks>This does not appear to be used by the MKIT interface.</remarks>
        public List<string> PreferredContactDays { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        /// <value>The addresses.</value>
        public List<CustomerAddressDetail> Addresses { get; set; } = new List<CustomerAddressDetail>();

        /// <summary>
        /// Gets or sets the phone numbers.
        /// </summary>
        public List<CustomerPhoneNumberDetail> PhoneNumbers { get; set; } = new List<CustomerPhoneNumberDetail>();

        /// <summary>
        /// Gets or sets the referred by name.
        /// </summary>
        /// <value>The referred by.</value>
        public string ReferredBy { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>The comments.</value>
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets the customer spouse.
        /// </summary>
        public CustomerSpouseDetail Spouse { get; set; }

        /// <summary>
        /// Gets or sets the customer gender.
        /// </summary>
        /// <value>The customer gender.</value>
        public CustomerGender? Gender { get; set; }

        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        /// <value>The note.</value>
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets the picture last updated date UTC.
        /// </summary>
        /// <value>The picture last updated date UTC.</value>
        public DateTime? PictureLastUpdatedDateUtc { get; set; }

        /// <summary>
        /// Gets or sets a list of social network details.
        /// </summary>
        public List<CustomerSocialNetworkDetail> SocialNetworks { get; set; } = new List<CustomerSocialNetworkDetail>();

        /// <summary>
        /// Gets or sets a customer birthday.
        /// </summary>
        public CustomerSpecialOccasionDetail Birthday { get; set; }

        /// <summary>
        /// Gets or sets a customer anniversary.
        /// </summary>
        public CustomerSpecialOccasionDetail Anniversary { get; set; }

        /// <summary>
        /// Gets or sets any additional customer important dates.
        /// </summary>
        public List<CustomerSpecialOccasionDetail> ImportantDates { get; set; } = new List<CustomerSpecialOccasionDetail>();

        /// <summary>
        /// Gets or sets a list of learning topics of interest.
        /// </summary>
        public List<CustomerLearningTopicsOfInterestTypes> LearningTopicsOfInterest { get; set; } = new List<CustomerLearningTopicsOfInterestTypes>();

        /// <summary>
        /// Gets or sets the email subscriptions.
        /// </summary>
        /// <value>The email subscriptions.</value>
        public List<CustomerEmailSubscriptionDetail> Subscriptions { get; set; } = new List<CustomerEmailSubscriptionDetail>();

        /// <summary>
        /// Gets or sets a value indicating whether the customer is registered.
        /// </summary>
        public bool? IsRegistered { get; set; }

        /// <summary>
        /// Gets or sets a list of preferred shipping methods
        /// </summary>
        /// <remarks>It does not appear to be used.</remarks>
        public List<string> PreferredShippingMethods { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the preferred shopping methods.
        /// </summary>
        public List<CustomerShoppingMethods> PreferredShoppingMethods { get; set; } = new List<CustomerShoppingMethods>();

        /// <summary>
        /// Gets or sets the preferred delivery method.
        /// </summary>
        /// <remarks>Does not appear to be used.</remarks>
        public string PreferredDeliveryMethod { get; set; }

        /// <summary>
        /// Gets or sets the preferred delivery method details if preferred method is Other.
        /// </summary>
        /// <remarks>Does not appear to be used.</remarks>
        public string PreferredDeliveryMethodDetailsIfOther { get; set; }

        /// <summary>
        /// Gets or sets a list of customer profile question group models.
        /// </summary>
        public List<CustomerProfileQuestionGroupDetail> ProfileQuestionGroups { get; set; } = new List<CustomerProfileQuestionGroupDetail>();
    }
}