﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BylkyWeb_RazorTemp.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Enter Valid Order must be between 1 and 100.")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
