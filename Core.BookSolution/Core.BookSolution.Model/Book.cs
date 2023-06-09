﻿using System.ComponentModel.DataAnnotations;

namespace Core.BookSolution.Model
{
    public class Book
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(64, MinimumLength = 5)]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
