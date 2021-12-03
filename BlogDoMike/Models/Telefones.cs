using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogDoMike.Models
{
    public class Telefones
    {
        public int Id { get; set; }
        [Required]
        [StringLength(11)]
        public string Number { get; set; }
    }
}