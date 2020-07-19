using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public Languages Language { get; set; }

    }
}