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
    /// Contains an enumerated list of special occasion types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerSpecialOccasionType
    {
        /// <summary>
        /// Anniversary.
        /// </summary>
        Anniversary,

        /// <summary>
        /// Birthday.
        /// </summary>
        Birthday,

        /// <summary>
        /// Graduation.
        /// </summary>
        Graduation,

        /// <summary>
        /// New baby.
        /// </summary>
        NewBaby,

        /// <summary>
        /// New job.
        /// </summary>
        NewJob,

        /// <summary>
        /// Vacation.
        /// </summary>
        Vacation,

        /// <summary>
        /// Wedding.
        /// </summary>
        Wedding,

        /// <summary>
        /// Other
        /// </summary>
        Other
    }

    /// <summary>
    /// This class represents a customer special occasion date.
    /// </summary>
    public class CustomerSpecialOccasion
    {
        /// <summary>
        /// Gets or sets the special occasion key.
        /// </summary>
        /// <value>The special occasion key.</value>
        public Guid SpecialOccasionKey { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the type of the special occasion.
        /// </summary>
        /// <value>The type of the special occasion.</value>
        public CustomerSpecialOccasionType SpecialOccasionType { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the day.
        /// </summary>
        /// <value>The day.</value>
        public int? Day { get; set; }

        /// <summary>
        /// Gets or sets the month.
        /// </summary>
        /// <value>The month.</value>
        public int? Month { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>The year.</value>
        public int? Year { get; set; }
    }
}