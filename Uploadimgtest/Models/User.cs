using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Uploadimgtest.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Nama { get; set; }

        [Required]
        public string Keterangan { get; set; }

        public string ImgPath { get; set; }

        [NotMapped]
        public IFormFile file { get; set; }
    }
}
