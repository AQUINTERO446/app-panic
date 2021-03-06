﻿namespace DemoPanic.Domain
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MaxLength(50, ErrorMessage = "El campo {0} solo puede tener un maximo de {1} caracteres.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [MaxLength(50, ErrorMessage = "El campo {0} solo puede tener un maximo de {1} caracteres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo {0}es requerido.")]
        [MaxLength(100, ErrorMessage = "El campo {0} solo puede tener un maximo de {1} caracteres.")]
        [Index("User_Email_Index", IsUnique = true)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MaxLength(20, ErrorMessage = "El campo {0} solo puede tener un maximo de {1} caracteres.")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [Display(Name = "Usuario")]
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        public int? UserTypeId { get; set; }

        [NotMapped]
        public string Password { get; set; }

        [JsonIgnore]
        public virtual UserType UserType { get; set; }

        public int? ClientTypeId { get; set; }

        [JsonIgnore]
        public virtual ClientType ClientType { get; set; }

        [DecimalPrecision(8, 6)]
        public decimal? Longitude { get; set; }

        [DecimalPrecision(8, 6)]
        public decimal? Latitude { get; set; }

    }
}