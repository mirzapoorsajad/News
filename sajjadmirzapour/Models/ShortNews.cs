﻿using System;
using System.ComponentModel.DataAnnotations;

namespace sajjadmirzapour.Models
{
    public class ShortNews
    {
        [Key]
        public int id;

        [Display(Name = "نویسنده")]
        [Required(ErrorMessage = "فیلد الزامی")]
        public string Writer { get; set; }

        [Display(Name = "عنوان خبر")]
        [Required(ErrorMessage = "فیلد الزامی")]
        public string NewsTitle { get; set; }

        [Display(Name = "توضیح کوتاه")]
        [Required(ErrorMessage = "فیلد الزامی")]
        public string ShortDescription { get; set; }

        [Display(Name = "توضیح")]
        [Required(ErrorMessage = "فیلد الزامی")]
        public string Description { get; set; }

        [Display(Name = "تاریخ")]
        public DateTime date { get; set; }

        [Display(Name = "تصویر")]
        public string Picture { get; set; }
    }
}
