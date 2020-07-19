using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repositories;
using WebApplication1.Request;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMovieRepository repository;
        public ValuesController(IMovieRepository repository)

        {
            this.repository = repository;
        }
        [HttpGet("Languages")]

        public IActionResult Languages()
        {
            return Ok(repository.AllLanguages());
        }

        [HttpGet("MoviesByLanguage/{langId}")]
        public IActionResult MovieByLanguage(int langId)
        {
            return Ok(repository.MovieByLanguage(langId));
        }

        [HttpGet("ReviewByMovieId/{MovId}")]
        public IActionResult ReviewByMovieId(int MovId)
        {
            return Ok(repository.GetReviewsByMovieId(MovId));
        }
         [HttpPost("AddReview")]
        public IActionResult AddGrade(AddReviewToMovieId data)
        {
            return Ok(repository.AddRev(data));
        }
    }
}
