﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Reviews
    {
        public int Id { get; set; }
        public string ReviewString { get; set; }
        public Movie Movie { get; set; }
    }
}