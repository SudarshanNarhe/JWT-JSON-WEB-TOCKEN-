﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JWT_JSON_WEB_TOCKEN_.Models
{
    [Table("emp")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [ScaffoldColumn(false)]
        public int IsActive { get; set; }

    }
}