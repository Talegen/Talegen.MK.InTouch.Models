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

    /// <summary>
    /// Contains an enumerated list of customer phone number types.
    /// </summary>
    public enum CustomerPhoneNumberType
    {
        /// <summary>
        /// Home number.
        /// </summary>
        Home,

        /// <summary>
        /// Work number.
        /// </summary>
        Work,

        /// <summary>
        /// Mobile number.
        /// </summary>
        Mobile
    }

    public class CustomerPhoneNumber
    {
        /// <summary>
        /// Gets or sets the phone number key.
        /// </summary>
        /// <value>The phone number key.</value>
        public Guid PhoneNumberKey { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the type of the phone number.
        /// </summary>
        /// <value>The type of the phone number.</value>
        public CustomerPhoneNumberType PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is primary.
        /// </summary>
        /// <value><c>true</c> if this instance is primary; otherwise, <c>false</c>.</value>
        public bool IsPrimary { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>The extension.</value>
        public string Extension { get; set; }
    }
}