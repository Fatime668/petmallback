﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Petmall.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Subtitle { get; set; }
        public string Title { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
