// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Transform encapsulates the rules or instructions for generating
    /// desired outputs from input media, such as by transcoding or by
    /// extracting insights. After the Transform is created, it can be applied
    /// to input media by creating Jobs.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Transform : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Transform class.
        /// </summary>
        public Transform()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Transform class.
        /// </summary>
        /// <param name="outputs">An array of one or more TransformOutputs that
        /// the Transform should generate.</param>
        /// <param name="id">Fully qualified resource ID for the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="created">The UTC date and time when the Transform was
        /// created, in 'YYYY-MM-DDThh:mm:ssZ' format.</param>
        /// <param name="description">An optional verbose description of the
        /// Transform.</param>
        /// <param name="lastModified">The UTC date and time when the Transform
        /// was last updated, in 'YYYY-MM-DDThh:mm:ssZ' format.</param>
        public Transform(IList<TransformOutput> outputs, string id = default(string), string name = default(string), string type = default(string), System.DateTime created = default(System.DateTime), string description = default(string), System.DateTime lastModified = default(System.DateTime))
            : base(id, name, type)
        {
            Created = created;
            Description = description;
            LastModified = lastModified;
            Outputs = outputs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the UTC date and time when the Transform was created, in
        /// 'YYYY-MM-DDThh:mm:ssZ' format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime Created { get; private set; }

        /// <summary>
        /// Gets or sets an optional verbose description of the Transform.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the UTC date and time when the Transform was last updated, in
        /// 'YYYY-MM-DDThh:mm:ssZ' format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModified")]
        public System.DateTime LastModified { get; private set; }

        /// <summary>
        /// Gets or sets an array of one or more TransformOutputs that the
        /// Transform should generate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputs")]
        public IList<TransformOutput> Outputs { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Outputs == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Outputs");
            }
            if (Outputs != null)
            {
                foreach (var element in Outputs)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
