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
    /// Telefono
    /// </summary>
    [DataContract]
    public partial class Telefono :  IEquatable<Telefono>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Telefono" /> class.
        /// </summary>
        /// <param name="codiceTipoTelefono">codiceTipoTelefono.</param>
        /// <param name="dataMovimentazione">dataMovimentazione.</param>
        /// <param name="descrizioneTipoTelefono">descrizioneTipoTelefono.</param>
        /// <param name="numeroTelefono">numeroTelefono.</param>
        public Telefono(string codiceTipoTelefono = default(string), int? dataMovimentazione = default(int?), string descrizioneTipoTelefono = default(string), string numeroTelefono = default(string))
        {
            this.CodiceTipoTelefono = codiceTipoTelefono;
            this.DataMovimentazione = dataMovimentazione;
            this.DescrizioneTipoTelefono = descrizioneTipoTelefono;
            this.NumeroTelefono = numeroTelefono;
        }
        
        /// <summary>
        /// Gets or Sets CodiceTipoTelefono
        /// </summary>
        [DataMember(Name="codiceTipoTelefono", EmitDefaultValue=false)]
        public string CodiceTipoTelefono { get; set; }

        /// <summary>
        /// Gets or Sets DataMovimentazione
        /// </summary>
        [DataMember(Name="dataMovimentazione", EmitDefaultValue=false)]
        public int? DataMovimentazione { get; set; }

        /// <summary>
        /// Gets or Sets DescrizioneTipoTelefono
        /// </summary>
        [DataMember(Name="descrizioneTipoTelefono", EmitDefaultValue=false)]
        public string DescrizioneTipoTelefono { get; set; }

        /// <summary>
        /// Gets or Sets NumeroTelefono
        /// </summary>
        [DataMember(Name="numeroTelefono", EmitDefaultValue=false)]
        public string NumeroTelefono { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Telefono {\n");
            sb.Append("  CodiceTipoTelefono: ").Append(CodiceTipoTelefono).Append("\n");
            sb.Append("  DataMovimentazione: ").Append(DataMovimentazione).Append("\n");
            sb.Append("  DescrizioneTipoTelefono: ").Append(DescrizioneTipoTelefono).Append("\n");
            sb.Append("  NumeroTelefono: ").Append(NumeroTelefono).Append("\n");
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
            return this.Equals(input as Telefono);
        }

        /// <summary>
        /// Returns true if Telefono instances are equal
        /// </summary>
        /// <param name="input">Instance of Telefono to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Telefono input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CodiceTipoTelefono == input.CodiceTipoTelefono ||
                    (this.CodiceTipoTelefono != null &&
                    this.CodiceTipoTelefono.Equals(input.CodiceTipoTelefono))
                ) && 
                (
                    this.DataMovimentazione == input.DataMovimentazione ||
                    (this.DataMovimentazione != null &&
                    this.DataMovimentazione.Equals(input.DataMovimentazione))
                ) && 
                (
                    this.DescrizioneTipoTelefono == input.DescrizioneTipoTelefono ||
                    (this.DescrizioneTipoTelefono != null &&
                    this.DescrizioneTipoTelefono.Equals(input.DescrizioneTipoTelefono))
                ) && 
                (
                    this.NumeroTelefono == input.NumeroTelefono ||
                    (this.NumeroTelefono != null &&
                    this.NumeroTelefono.Equals(input.NumeroTelefono))
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
                if (this.CodiceTipoTelefono != null)
                    hashCode = hashCode * 59 + this.CodiceTipoTelefono.GetHashCode();
                if (this.DataMovimentazione != null)
                    hashCode = hashCode * 59 + this.DataMovimentazione.GetHashCode();
                if (this.DescrizioneTipoTelefono != null)
                    hashCode = hashCode * 59 + this.DescrizioneTipoTelefono.GetHashCode();
                if (this.NumeroTelefono != null)
                    hashCode = hashCode * 59 + this.NumeroTelefono.GetHashCode();
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
