﻿using System.ComponentModel.DataAnnotations;

namespace sajjadmirzapour.Models
{
    public class ShortTextNews
    {
        [Key]
        public int id;

        [Display(Name = "توضیح")]
        [Required(ErrorMessage = "فیلد الزامی")]
        public string Description { get; set; }

    }
}
