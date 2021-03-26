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
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// This class contains the common properties used throughout all customer models.
    /// </summary>
    public abstract class CustomerBase
    {
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>The customer identifier.</value>
        public Guid CustomerId { get; set; } = Guid.NewGuid();

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
        /// Gets or sets the profile date UTC.
        /// </summary>
        /// <value>The profile date UTC.</value>
        public DateTime? ProfileDateUtc { get; set; }

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
        /// Gets or sets the tags.
        /// </summary>
        /// <value>The tags.</value>
        public List<string> Tags { get; set; } = new List<string>();
    }
}