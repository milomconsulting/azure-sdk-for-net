// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using System.Linq;

    /// <summary>
    /// An array of 0 to 16 identities that have access to the key vault. All
    /// identities in the array must use the same tenant ID as the key
    /// vault's tenant ID.
    /// </summary>
    public partial class AccessPolicyEntry
    {
        /// <summary>
        /// Initializes a new instance of the AccessPolicyEntry class.
        /// </summary>
        public AccessPolicyEntry() { }

        /// <summary>
        /// Initializes a new instance of the AccessPolicyEntry class.
        /// </summary>
        /// <param name="tenantId">The Azure Active Directory tenant ID that
        /// should be used for authenticating requests to the key
        /// vault.</param>
        /// <param name="objectId">The object ID of a user or service
        /// principal in the Azure Active Directory tenant for the vault. The
        /// object ID must be unique for the list of access policies.</param>
        /// <param name="permissions">Permissions the identity has for keys
        /// and secrets</param>
        /// <param name="applicationId"> Application ID of the client making
        /// request on behalf of a principal</param>
        public AccessPolicyEntry(System.Guid tenantId, System.Guid objectId, Permissions permissions, System.Guid? applicationId = default(System.Guid?))
        {
            TenantId = tenantId;
            ObjectId = objectId;
            ApplicationId = applicationId;
            Permissions = permissions;
        }

        /// <summary>
        /// Gets or sets the Azure Active Directory tenant ID that should be
        /// used for authenticating requests to the key vault.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tenantId")]
        public System.Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the object ID of a user or service principal in the
        /// Azure Active Directory tenant for the vault. The object ID must
        /// be unique for the list of access policies.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "objectId")]
        public System.Guid ObjectId { get; set; }

        /// <summary>
        /// Gets or sets  Application ID of the client making request on
        /// behalf of a principal
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "applicationId")]
        public System.Guid? ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets permissions the identity has for keys and secrets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "permissions")]
        public Permissions Permissions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Permissions == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Permissions");
            }
        }
    }
}