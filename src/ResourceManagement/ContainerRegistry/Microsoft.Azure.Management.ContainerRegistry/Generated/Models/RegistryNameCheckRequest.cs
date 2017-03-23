// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Azure;
    using Management;
    using ContainerRegistry;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A request to check whether a container registry name is available.
    /// </summary>
    public partial class RegistryNameCheckRequest
    {
        /// <summary>
        /// Initializes a new instance of the RegistryNameCheckRequest class.
        /// </summary>
        public RegistryNameCheckRequest() { }

        /// <summary>
        /// Initializes a new instance of the RegistryNameCheckRequest class.
        /// </summary>
        /// <param name="name">The name of the container registry.</param>
        public RegistryNameCheckRequest(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Static constructor for RegistryNameCheckRequest class.
        /// </summary>
        static RegistryNameCheckRequest()
        {
            Type = "Microsoft.ContainerRegistry/registries";
        }

        /// <summary>
        /// Gets or sets the name of the container registry.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The resource type of the container registry. This field must be set
        /// to "Microsoft.ContainerRegistry/registries".
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Name != null)
            {
                if (Name.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 50);
                }
                if (Name.Length < 5)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 5);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(Name, "^[a-zA-Z0-9]*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[a-zA-Z0-9]*$");
                }
            }
        }
    }
}

