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
    /// PersonaFisicaDTO
    /// </summary>
    [DataContract]
    public partial class PersonaFisicaDTO :  IEquatable<PersonaFisicaDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonaFisicaDTO" /> class.
        /// </summary>
        /// <param name="codiceFiscale">codiceFiscale.</param>
        /// <param name="cognome">cognome.</param>
        /// <param name="dataNascita">dataNascita.</param>
        /// <param name="dataNascitaAl">dataNascitaAl.</param>
        /// <param name="dataNascitaDal">dataNascitaDal.</param>
        /// <param name="istatComuneNascita">istatComuneNascita.</param>
        /// <param name="nome">nome.</param>
        /// <param name="paginazIn">paginazIn.</param>
        /// <param name="paginazOut">paginazOut.</param>
        /// <param name="uuid">uuid.</param>
        public PersonaFisicaDTO(string codiceFiscale = default(string), string cognome = default(string), string dataNascita = default(string), string dataNascitaAl = default(string), string dataNascitaDal = default(string), string istatComuneNascita = default(string), string nome = default(string), decimal? paginazIn = default(decimal?), decimal? paginazOut = default(decimal?), decimal? uuid = default(decimal?))
        {
            this.CodiceFiscale = codiceFiscale;
            this.Cognome = cognome;
            this.DataNascita = dataNascita;
            this.DataNascitaAl = dataNascitaAl;
            this.DataNascitaDal = dataNascitaDal;
            this.IstatComuneNascita = istatComuneNascita;
            this.Nome = nome;
            this.PaginazIn = paginazIn;
            this.PaginazOut = paginazOut;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Gets or Sets CodiceFiscale
        /// </summary>
        [DataMember(Name="codiceFiscale", EmitDefaultValue=false)]
        public string CodiceFiscale { get; set; }

        /// <summary>
        /// Gets or Sets Cognome
        /// </summary>
        [DataMember(Name="cognome", EmitDefaultValue=false)]
        public string Cognome { get; set; }

        /// <summary>
        /// Gets or Sets DataNascita
        /// </summary>
        [DataMember(Name="dataNascita", EmitDefaultValue=false)]
        public string DataNascita { get; set; }

        /// <summary>
        /// Gets or Sets DataNascitaAl
        /// </summary>
        [DataMember(Name="dataNascitaAl", EmitDefaultValue=false)]
        public string DataNascitaAl { get; set; }

        /// <summary>
        /// Gets or Sets DataNascitaDal
        /// </summary>
        [DataMember(Name="dataNascitaDal", EmitDefaultValue=false)]
        public string DataNascitaDal { get; set; }

        /// <summary>
        /// Gets or Sets IstatComuneNascita
        /// </summary>
        [DataMember(Name="istatComuneNascita", EmitDefaultValue=false)]
        public string IstatComuneNascita { get; set; }

        /// <summary>
        /// Gets or Sets Nome
        /// </summary>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }

        /// <summary>
        /// Gets or Sets PaginazIn
        /// </summary>
        [DataMember(Name="paginazIn", EmitDefaultValue=false)]
        public decimal? PaginazIn { get; set; }

        /// <summary>
        /// Gets or Sets PaginazOut
        /// </summary>
        [DataMember(Name="paginazOut", EmitDefaultValue=false)]
        public decimal? PaginazOut { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public decimal? Uuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonaFisicaDTO {\n");
            sb.Append("  CodiceFiscale: ").Append(CodiceFiscale).Append("\n");
            sb.Append("  Cognome: ").Append(Cognome).Append("\n");
            sb.Append("  DataNascita: ").Append(DataNascita).Append("\n");
            sb.Append("  DataNascitaAl: ").Append(DataNascitaAl).Append("\n");
            sb.Append("  DataNascitaDal: ").Append(DataNascitaDal).Append("\n");
            sb.Append("  IstatComuneNascita: ").Append(IstatComuneNascita).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  PaginazIn: ").Append(PaginazIn).Append("\n");
            sb.Append("  PaginazOut: ").Append(PaginazOut).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            return this.Equals(input as PersonaFisicaDTO);
        }

        /// <summary>
        /// Returns true if PersonaFisicaDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PersonaFisicaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonaFisicaDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CodiceFiscale == input.CodiceFiscale ||
                    (this.CodiceFiscale != null &&
                    this.CodiceFiscale.Equals(input.CodiceFiscale))
                ) && 
                (
                    this.Cognome == input.Cognome ||
                    (this.Cognome != null &&
                    this.Cognome.Equals(input.Cognome))
                ) && 
                (
                    this.DataNascita == input.DataNascita ||
                    (this.DataNascita != null &&
                    this.DataNascita.Equals(input.DataNascita))
                ) && 
                (
                    this.DataNascitaAl == input.DataNascitaAl ||
                    (this.DataNascitaAl != null &&
                    this.DataNascitaAl.Equals(input.DataNascitaAl))
                ) && 
                (
                    this.DataNascitaDal == input.DataNascitaDal ||
                    (this.DataNascitaDal != null &&
                    this.DataNascitaDal.Equals(input.DataNascitaDal))
                ) && 
                (
                    this.IstatComuneNascita == input.IstatComuneNascita ||
                    (this.IstatComuneNascita != null &&
                    this.IstatComuneNascita.Equals(input.IstatComuneNascita))
                ) && 
                (
                    this.Nome == input.Nome ||
                    (this.Nome != null &&
                    this.Nome.Equals(input.Nome))
                ) && 
                (
                    this.PaginazIn == input.PaginazIn ||
                    (this.PaginazIn != null &&
                    this.PaginazIn.Equals(input.PaginazIn))
                ) && 
                (
                    this.PaginazOut == input.PaginazOut ||
                    (this.PaginazOut != null &&
                    this.PaginazOut.Equals(input.PaginazOut))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.CodiceFiscale != null)
                    hashCode = hashCode * 59 + this.CodiceFiscale.GetHashCode();
                if (this.Cognome != null)
                    hashCode = hashCode * 59 + this.Cognome.GetHashCode();
                if (this.DataNascita != null)
                    hashCode = hashCode * 59 + this.DataNascita.GetHashCode();
                if (this.DataNascitaAl != null)
                    hashCode = hashCode * 59 + this.DataNascitaAl.GetHashCode();
                if (this.DataNascitaDal != null)
                    hashCode = hashCode * 59 + this.DataNascitaDal.GetHashCode();
                if (this.IstatComuneNascita != null)
                    hashCode = hashCode * 59 + this.IstatComuneNascita.GetHashCode();
                if (this.Nome != null)
                    hashCode = hashCode * 59 + this.Nome.GetHashCode();
                if (this.PaginazIn != null)
                    hashCode = hashCode * 59 + this.PaginazIn.GetHashCode();
                if (this.PaginazOut != null)
                    hashCode = hashCode * 59 + this.PaginazOut.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
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