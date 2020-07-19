using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTO;
using WebApplication1.Models;
using WebApplication1.Request;

namespace WebApplication1.Repositories
{
    public interface IMovieRepository
    {

        List<Languages> AllLanguages();

        List<MoviesDTO> MovieByLanguage(int langId);
        List<ReviewsDTO> GetReviewsByMovieId(int MovId);
        bool AddRev(AddReviewToMovieId request);
    }
}
