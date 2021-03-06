﻿namespace DemoPanic.Domain
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserType
    {
        [Key]
        public int UserTypeId { get; set; }

        [Required(ErrorMessage = "El campo {0}es requerido.")]
        [MaxLength(50, ErrorMessage = "El campo {0} solo puede tener un maximo de {1} caracteres.")]
        [Index("UserType_Name_Index", IsUnique = true)]
        public string  Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
