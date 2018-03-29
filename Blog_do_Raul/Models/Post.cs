﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog_do_Raul.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [StringLength(500)]

        public string Title { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateUpdate { get; set; }
        [Required]
        [StringLength(8000)]
        public string PostingBody { get; set; }
    }
}