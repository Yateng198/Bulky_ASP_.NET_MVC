﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyBookWebRazor_temp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Category name length must less than 30 charaters!")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "DisplayOrder must be between 1-100!")]
        public int DisplayOrder { get; set; }
    }
}
