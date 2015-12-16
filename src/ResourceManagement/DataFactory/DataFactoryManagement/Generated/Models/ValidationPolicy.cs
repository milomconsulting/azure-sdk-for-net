// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// Validation policy.
    /// </summary>
    public partial class ValidationPolicy
    {
        private long? _minimumRows;
        
        /// <summary>
        /// Optional. Minimum rows.
        /// </summary>
        public long? MinimumRows
        {
            get { return this._minimumRows; }
            set { this._minimumRows = value; }
        }
        
        private double? _minimumSizeMB;
        
        /// <summary>
        /// Optional. Minimum size in MB.
        /// </summary>
        public double? MinimumSizeMB
        {
            get { return this._minimumSizeMB; }
            set { this._minimumSizeMB = value; }
        }
        
        private string _validationPriorityOrder;
        
        /// <summary>
        /// Optional. Validation priority order.  Choose from OldestFirst or
        /// NewestFirst.
        /// </summary>
        public string ValidationPriorityOrder
        {
            get { return this._validationPriorityOrder; }
            set { this._validationPriorityOrder = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ValidationPolicy class.
        /// </summary>
        public ValidationPolicy()
        {
        }
    }
}