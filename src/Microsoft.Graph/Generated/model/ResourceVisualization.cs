// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ResourceVisualization.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ResourceVisualization
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceVisualization"/> class.
        /// </summary>
        public ResourceVisualization()
        {
            this.ODataType = "microsoft.graph.resourceVisualization";
        }

        /// <summary>
        /// Gets or sets containerDisplayName.
        /// A string describing where the item is stored. For example, the name of a SharePoint site or the user name identifying the owner of the OneDrive storing the item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "containerDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string ContainerDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets containerType.
        /// Can be used for filtering by the type of container in which the file is stored. Such as Site or OneDriveBusiness.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "containerType", Required = Newtonsoft.Json.Required.Default)]
        public string ContainerType { get; set; }
    
        /// <summary>
        /// Gets or sets containerWebUrl.
        /// A path leading to the folder in which the item is stored.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "containerWebUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ContainerWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets mediaType.
        /// The item's media type. Can be used for filtering for a specific type of file based on supported IANA Media Mime Types. Note that not all Media Mime Types are supported.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaType", Required = Newtonsoft.Json.Required.Default)]
        public string MediaType { get; set; }
    
        /// <summary>
        /// Gets or sets previewImageUrl.
        /// A URL leading to the preview image for the item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previewImageUrl", Required = Newtonsoft.Json.Required.Default)]
        public string PreviewImageUrl { get; set; }
    
        /// <summary>
        /// Gets or sets previewText.
        /// A preview text for the item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previewText", Required = Newtonsoft.Json.Required.Default)]
        public string PreviewText { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// The item's title text.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Newtonsoft.Json.Required.Default)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The item's media type. Can be used for filtering for a specific file based on a specific type. See below for supported types.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
