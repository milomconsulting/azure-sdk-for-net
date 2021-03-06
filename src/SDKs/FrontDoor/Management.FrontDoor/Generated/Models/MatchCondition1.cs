// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Define match conditions
    /// </summary>
    public partial class MatchCondition1
    {
        /// <summary>
        /// Initializes a new instance of the MatchCondition1 class.
        /// </summary>
        public MatchCondition1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MatchCondition1 class.
        /// </summary>
        /// <param name="matchVariable">Match Variable. Possible values
        /// include: 'RemoteAddr', 'RequestMethod', 'QueryString', 'PostArgs',
        /// 'RequestUri', 'RequestHeader', 'RequestBody'</param>
        /// <param name="operatorProperty">Describes operator to be matched.
        /// Possible values include: 'Any', 'IPMatch', 'GeoMatch', 'Equal',
        /// 'Contains', 'LessThan', 'GreaterThan', 'LessThanOrEqual',
        /// 'GreaterThanOrEqual', 'BeginsWith', 'EndsWith'</param>
        /// <param name="matchValue">Match value</param>
        /// <param name="selector">Name of selector in RequestHeader or
        /// RequestBody to be matched</param>
        /// <param name="negateCondition">Describes if this is negate condition
        /// or not</param>
        public MatchCondition1(string matchVariable, string operatorProperty, IList<string> matchValue, string selector = default(string), bool? negateCondition = default(bool?))
        {
            MatchVariable = matchVariable;
            Selector = selector;
            OperatorProperty = operatorProperty;
            NegateCondition = negateCondition;
            MatchValue = matchValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets match Variable. Possible values include: 'RemoteAddr',
        /// 'RequestMethod', 'QueryString', 'PostArgs', 'RequestUri',
        /// 'RequestHeader', 'RequestBody'
        /// </summary>
        [JsonProperty(PropertyName = "matchVariable")]
        public string MatchVariable { get; set; }

        /// <summary>
        /// Gets or sets name of selector in RequestHeader or RequestBody to be
        /// matched
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public string Selector { get; set; }

        /// <summary>
        /// Gets or sets describes operator to be matched. Possible values
        /// include: 'Any', 'IPMatch', 'GeoMatch', 'Equal', 'Contains',
        /// 'LessThan', 'GreaterThan', 'LessThanOrEqual', 'GreaterThanOrEqual',
        /// 'BeginsWith', 'EndsWith'
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string OperatorProperty { get; set; }

        /// <summary>
        /// Gets or sets describes if this is negate condition or not
        /// </summary>
        [JsonProperty(PropertyName = "negateCondition")]
        public bool? NegateCondition { get; set; }

        /// <summary>
        /// Gets or sets match value
        /// </summary>
        [JsonProperty(PropertyName = "matchValue")]
        public IList<string> MatchValue { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MatchVariable == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MatchVariable");
            }
            if (OperatorProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OperatorProperty");
            }
            if (MatchValue == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MatchValue");
            }
        }
    }
}
