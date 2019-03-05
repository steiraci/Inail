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
using SwaggerDateConverter = IO.Swagger.Au.Client.SwaggerDateConverter;

namespace IO.Swagger.Au.Model
{
    /// <summary>
    /// Ruolo
    /// </summary>
    [DataContract]
    public partial class Ruolo :  IEquatable<Ruolo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ruolo" /> class.
        /// </summary>
        /// <param name="codiceRuolo">codiceRuolo.</param>
        /// <param name="dataInizio">dataInizio.</param>
        /// <param name="descrizioneRuolo">descrizioneRuolo.</param>
        public Ruolo(string codiceRuolo = default(string), int? dataInizio = default(int?), string descrizioneRuolo = default(string))
        {
            this.CodiceRuolo = codiceRuolo;
            this.DataInizio = dataInizio;
            this.DescrizioneRuolo = descrizioneRuolo;
        }
        
        /// <summary>
        /// Gets or Sets CodiceRuolo
        /// </summary>
        [DataMember(Name="codiceRuolo", EmitDefaultValue=false)]
        public string CodiceRuolo { get; set; }

        /// <summary>
        /// Gets or Sets DataInizio
        /// </summary>
        [DataMember(Name="dataInizio", EmitDefaultValue=false)]
        public int? DataInizio { get; set; }

        /// <summary>
        /// Gets or Sets DescrizioneRuolo
        /// </summary>
        [DataMember(Name="descrizioneRuolo", EmitDefaultValue=false)]
        public string DescrizioneRuolo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ruolo {\n");
            sb.Append("  CodiceRuolo: ").Append(CodiceRuolo).Append("\n");
            sb.Append("  DataInizio: ").Append(DataInizio).Append("\n");
            sb.Append("  DescrizioneRuolo: ").Append(DescrizioneRuolo).Append("\n");
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
            return this.Equals(input as Ruolo);
        }

        /// <summary>
        /// Returns true if Ruolo instances are equal
        /// </summary>
        /// <param name="input">Instance of Ruolo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ruolo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CodiceRuolo == input.CodiceRuolo ||
                    (this.CodiceRuolo != null &&
                    this.CodiceRuolo.Equals(input.CodiceRuolo))
                ) && 
                (
                    this.DataInizio == input.DataInizio ||
                    (this.DataInizio != null &&
                    this.DataInizio.Equals(input.DataInizio))
                ) && 
                (
                    this.DescrizioneRuolo == input.DescrizioneRuolo ||
                    (this.DescrizioneRuolo != null &&
                    this.DescrizioneRuolo.Equals(input.DescrizioneRuolo))
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
                if (this.CodiceRuolo != null)
                    hashCode = hashCode * 59 + this.CodiceRuolo.GetHashCode();
                if (this.DataInizio != null)
                    hashCode = hashCode * 59 + this.DataInizio.GetHashCode();
                if (this.DescrizioneRuolo != null)
                    hashCode = hashCode * 59 + this.DescrizioneRuolo.GetHashCode();
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