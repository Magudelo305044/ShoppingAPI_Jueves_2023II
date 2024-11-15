﻿using System.ComponentModel.DataAnnotations;

namespace ShoppingAPI_Jueves_2023II.DAL.Entities
{
    public class Country : AuditBase
    {
        [Display(Name = "País")] // Para identificar el nombre más fácil
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] // Longitud máx
        [Required(ErrorMessage = "Es campo {0} es obligatorio")] // Campo obligatorio
        public string Name { get; set; }

        [Display(Name = "Categorias")]
        //relación con Categoria 
        public ICollection<Categoria>? States { get; set; }
    }
}