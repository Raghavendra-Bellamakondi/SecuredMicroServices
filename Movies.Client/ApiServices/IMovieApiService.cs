using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movies.Client.Models;

namespace Movies.Client.ApiServices
{
    public interface IMovieApiService
    {
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovie(string Id);
        Task<Movie> CreateMovie(Movie movie);
        Task<Movie> UpdateMovie(Movie movie);
        Task DeleteMovie(int Id);

    }
}
