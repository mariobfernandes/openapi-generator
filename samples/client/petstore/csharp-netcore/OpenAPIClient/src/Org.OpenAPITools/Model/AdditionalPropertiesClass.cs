/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using OpenAPIAdditionalPropertiesConverter = Org.OpenAPITools.Client.OpenAPIAdditionalPropertiesConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// AdditionalPropertiesClass
    /// </summary>
    [DataContract(Name = "AdditionalPropertiesClass")]
    public partial class AdditionalPropertiesClass : IEquatable<AdditionalPropertiesClass>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalPropertiesClass" /> class.
        /// </summary>
        /// <param name="mapProperty">mapProperty.</param>
        /// <param name="mapOfMapProperty">mapOfMapProperty.</param>
        public AdditionalPropertiesClass(Dictionary<string, string> mapProperty = default(Dictionary<string, string>), Dictionary<string, Dictionary<string, string>> mapOfMapProperty = default(Dictionary<string, Dictionary<string, string>>))
        {
            this.MapProperty = mapProperty;
            this.MapOfMapProperty = mapOfMapProperty;
            this.AdditionalProperites = new Dictionary<string, dynamic>();
        }

        /// <summary>
        /// Gets or Sets MapProperty
        /// </summary>
        [DataMember(Name = "map_property", EmitDefaultValue = false)]
        public Dictionary<string, string> MapProperty { get; set; }

        /// <summary>
        /// Gets or Sets MapOfMapProperty
        /// </summary>
        [DataMember(Name = "map_of_map_property", EmitDefaultValue = false)]
        public Dictionary<string, Dictionary<string, string>> MapOfMapProperty { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIAdditionalPropertiesConverter))]
        public Dictionary<string, dynamic> AdditionalProperites { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalPropertiesClass {\n");
            sb.Append("  MapProperty: ").Append(MapProperty).Append("\n");
            sb.Append("  MapOfMapProperty: ").Append(MapOfMapProperty).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as AdditionalPropertiesClass).AreEqual;
        }

        /// <summary>
        /// Returns true if AdditionalPropertiesClass instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalPropertiesClass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalPropertiesClass input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.MapProperty != null)
                    hashCode = hashCode * 59 + this.MapProperty.GetHashCode();
                if (this.MapOfMapProperty != null)
                    hashCode = hashCode * 59 + this.MapOfMapProperty.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
