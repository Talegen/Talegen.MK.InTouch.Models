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
    /// Contains an enumerated list of customer address types.
    /// </summary>
    public enum CustomerAddressType
    {
        /// <summary>
        /// Home address.
        /// </summary>
        Home,

        /// <summary>
        /// Business address.
        /// </summary>
        Business,

        /// <summary>
        /// Other address.
        /// </summary>
        Other
    }

    /// <summary>
    /// This class represents a customer postal address.
    /// </summary>
    public class CustomerAddress
    {
        /// <summary>
        /// Gets or sets the address key.
        /// </summary>
        /// <value>The address key.</value>
        public Guid AddressKey { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the type of the address.
        /// </summary>
        /// <value>The type of the address.</value>
        public CustomerAddressType AddressType { get; set; }

        /// <summary>
        /// Gets or sets the name of the address.
        /// </summary>
        /// <value>The name of the address.</value>
        public string AddressName { get; set; }

        /// <summary>
        /// Gets or sets the addressee.
        /// </summary>
        /// <value>The addressee.</value>
        public string Addressee { get; set; }

        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        /// <value>The street.</value>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the unit number.
        /// </summary>
        /// <value>The unit number.</value>
        public string UnitNumber { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the region code.
        /// </summary>
        /// <value>The region code.</value>
        public string RegionCode { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        /// <value>The country code.</value>
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>The postal code.</value>
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is primary.
        /// </summary>
        /// <value><c>true</c> if this instance is primary; otherwise, <c>false</c>.</value>
        public bool IsPrimary { get; set; }

        /// <summary>
        /// Gets or sets the telephone.
        /// </summary>
        /// <value>The telephone.</value>
        public string Telephone { get; set; }
    }
}