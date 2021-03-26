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
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    /// <summary>
    /// This class represents a customer profile question group detail model.
    /// </summary>
    /// <remarks>Because the MKIT developers decided to change casing of JSON models between queries, we must make a unique class with naming strategy.</remarks>
    /// <seealso cref="Talegen.MK.InTouch.Models.Customers.CustomerSpouse" />
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CustomerProfileQuestionGroupDetail : CustomerProfileQuestionGroup
    {
        /// <summary>
        /// Gets or sets the questions.
        /// </summary>
        /// <value>The questions.</value>
        public new List<CustomerProfileQuestionDetail> Questions { get; set; } = new List<CustomerProfileQuestionDetail>();
    }
}