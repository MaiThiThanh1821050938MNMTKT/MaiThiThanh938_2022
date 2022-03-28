using System;
using System.ComponentModel.DataAnnotations;

namespace MaiThiThanh2022938.Models
{
    public class PersonMTT2022938
    {
        [Key]
        public int PersonId { get; set; }
        [Display(Name = "Tên")]
        public string? PersonName { get; set; }
    }
}
