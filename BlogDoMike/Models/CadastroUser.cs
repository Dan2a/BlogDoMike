using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogDoMike.Models
{
    public class CadastroUser
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string CPF { get; set; }
        [Required]
        [StringLength(150)]
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Telefones Telefones { get; set; }
        public int TelefoneId { get; set; }

    }
}