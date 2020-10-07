// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsBeta_DistRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsBeta_DistRequestBody
    {
    
        /// <summary>
        /// Gets or sets X.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "x", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken X { get; set; }
    
        /// <summary>
        /// Gets or sets Alpha.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alpha", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Alpha { get; set; }
    
        /// <summary>
        /// Gets or sets Beta.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "beta", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Beta { get; set; }
    
        /// <summary>
        /// Gets or sets Cumulative.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cumulative", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Cumulative { get; set; }
    
        /// <summary>
        /// Gets or sets A.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "A", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken A { get; set; }
    
        /// <summary>
        /// Gets or sets B.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "B", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken B { get; set; }
    
    }
}