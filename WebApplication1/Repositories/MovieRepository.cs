using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DTO;
using WebApplication1.Models;
using WebApplication1.Request;

namespace WebApplication1.Repositories
{
    public class MovieRepository
    {
        private readonly FileDbContext db;
        public MovieRepository(FileDbContext _db)
        {
            this.db = _db;
        }
        public List<Languages> AllLanguages()
        {
            return db.Languages.ToList();
        }
        public List<ReviewsDTO> GetReviewsByMovieId(int MovId)
        {
            var reviews = db.Reviews.Include("Movie").Where(a => a.Movie.MovieId == MovId).ToList();
            List<ReviewsDTO> reviewData = new List<ReviewsDTO>();

            foreach (var review in reviews)
            {
                reviewData.Add(new ReviewsDTO
                {
                    ReviewId = review.Id,
                    ReviewText = review.ReviewString,
                    Review = review.Movie.Name
                });
            }
            return reviewData;
        }
        public List<MoviesDTO> MovieByLanguage(int langId)
        {

            var movies = db.Movies.Include("Language").Where(a => a.Language.Id == langId).ToList();
            List<MoviesDTO> movieData = new List<MoviesDTO>();

            foreach (var movie in movies)
            {
                movieData.Add(new MoviesDTO
                {
                    MovieName = movie.Name,
                    MovieLanguage = movie.Language.Language
                });
            }

            return movieData;
        }
        public bool AddRev(AddReviewToMovieId request)
        {
            if (request.ReviewContent != null && request.MovId > 0)
            {
                var mov = db.Movies.Where(a => a.MovieId == request.MovId).FirstOrDefault();

                Reviews review = new Reviews();
                review.ReviewString = request.ReviewContent;
                review.Movie = mov;
                db.Reviews.Add(review);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
