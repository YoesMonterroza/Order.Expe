﻿using Orders.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Shared.Entities
{
    public class Country : IEntityWithName
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(100, ErrorMessage ="El campo {0} no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "E campo {0} es requerido")]
        public string Name { get; set; } = null!;

    }
}
