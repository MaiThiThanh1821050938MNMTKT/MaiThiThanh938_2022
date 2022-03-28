using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MaiThiThanh2022938.Models
{
    public class MTT0938
    {
        [Key]
        public string? MTTId { get; set; }
         [Display(Name = "Tên")]
        public string? MTTName { get; set; }
         [Display(Name = "Giới Tính")]
        public bool? MTTGender { get; set; }
    }
}