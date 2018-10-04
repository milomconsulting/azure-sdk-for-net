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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Round-Robin load balancing settings for a backend pool
    /// </summary>
    public partial class LoadBalancingSettingsUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LoadBalancingSettingsUpdateParameters class.
        /// </summary>
        public LoadBalancingSettingsUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LoadBalancingSettingsUpdateParameters class.
        /// </summary>
        /// <param name="sampleSize">The number of samples to consider for load
        /// balancing decisions</param>
        /// <param name="successfulSamplesRequired">The number of samples
        /// within the sample period that must succeed</param>
        /// <param name="additionalLatencyMilliseconds">The additional latency
        /// in milliseconds for probes to fall into the lowest latency
        /// bucket</param>
        public LoadBalancingSettingsUpdateParameters(int? sampleSize = default(int?), int? successfulSamplesRequired = default(int?), int? additionalLatencyMilliseconds = default(int?))
        {
            SampleSize = sampleSize;
            SuccessfulSamplesRequired = successfulSamplesRequired;
            AdditionalLatencyMilliseconds = additionalLatencyMilliseconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of samples to consider for load balancing
        /// decisions
        /// </summary>
        [JsonProperty(PropertyName = "sampleSize")]
        public int? SampleSize { get; set; }

        /// <summary>
        /// Gets or sets the number of samples within the sample period that
        /// must succeed
        /// </summary>
        [JsonProperty(PropertyName = "successfulSamplesRequired")]
        public int? SuccessfulSamplesRequired { get; set; }

        /// <summary>
        /// Gets or sets the additional latency in milliseconds for probes to
        /// fall into the lowest latency bucket
        /// </summary>
        [JsonProperty(PropertyName = "additionalLatencyMilliseconds")]
        public int? AdditionalLatencyMilliseconds { get; set; }

    }
}