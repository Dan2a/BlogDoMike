using BlogDoMike.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogDoMike.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [StringLength(4000)]
        [AllowHtml]
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public IEnumerable<Author> Author { get; set; }
        [Required]
        public int Author_Id { get; set; }

    }
}