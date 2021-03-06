// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The key vault error exception.
    /// </summary>
    public partial class KeyVaultError
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultError class.
        /// </summary>
        public KeyVaultError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVaultError class.
        /// </summary>
        public KeyVaultError(Error error = default(Error))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Error Error { get; private set; }

    }
}
