/* 
 * @project.name@
 *
 * @project.description@
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// SedeAsl
    /// </summary>
    [DataContract]
    public partial class SedeAsl :  IEquatable<SedeAsl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SedeAsl" /> class.
        /// </summary>
        /// <param name="codiceSede">codiceSede.</param>
        /// <param name="dataInizio">dataInizio.</param>
        /// <param name="descrizione">descrizione.</param>
        public SedeAsl(string codiceSede = default(string), int? dataInizio = default(int?), string descrizione = default(string))
        {
            this.CodiceSede = codiceSede;
            this.DataInizio = dataInizio;
            this.Descrizione = descrizione;
        }
        
        /// <summary>
        /// Gets or Sets CodiceSede
        /// </summary>
        [DataMember(Name="codiceSede", EmitDefaultValue=false)]
        public string CodiceSede { get; set; }

        /// <summary>
        /// Gets or Sets DataInizio
        /// </summary>
        [DataMember(Name="dataInizio", EmitDefaultValue=false)]
        public int? DataInizio { get; set; }

        /// <summary>
        /// Gets or Sets Descrizione
        /// </summary>
        [DataMember(Name="descrizione", EmitDefaultValue=false)]
        public string Descrizione { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SedeAsl {\n");
            sb.Append("  CodiceSede: ").Append(CodiceSede).Append("\n");
            sb.Append("  DataInizio: ").Append(DataInizio).Append("\n");
            sb.Append("  Descrizione: ").Append(Descrizione).Append("\n");
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
            return this.Equals(input as SedeAsl);
        }

        /// <summary>
        /// Returns true if SedeAsl instances are equal
        /// </summary>
        /// <param name="input">Instance of SedeAsl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SedeAsl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CodiceSede == input.CodiceSede ||
                    (this.CodiceSede != null &&
                    this.CodiceSede.Equals(input.CodiceSede))
                ) && 
                (
                    this.DataInizio == input.DataInizio ||
                    (this.DataInizio != null &&
                    this.DataInizio.Equals(input.DataInizio))
                ) && 
                (
                    this.Descrizione == input.Descrizione ||
                    (this.Descrizione != null &&
                    this.Descrizione.Equals(input.Descrizione))
                );
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
                if (this.CodiceSede != null)
                    hashCode = hashCode * 59 + this.CodiceSede.GetHashCode();
                if (this.DataInizio != null)
                    hashCode = hashCode * 59 + this.DataInizio.GetHashCode();
                if (this.Descrizione != null)
                    hashCode = hashCode * 59 + this.Descrizione.GetHashCode();
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
