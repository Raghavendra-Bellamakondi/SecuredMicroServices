using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movies.Client.Models;

namespace Movies.Client.ApiServices
{
    public class MovieApiService : IMovieApiService
    {
        public Task<Movie> CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMovie(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetMovie(string Id)
        {
            throw new NotImplementedException();
        }

        public  async Task<IEnumerable<Movie>> GetMovies()
        {
            var lstMovies = new List<Movie>() {
            new Movie(){
                Id=1,
                Title="Singham Returns",
                Rating="4.5"
               
            }};
            return await Task.FromResult(lstMovies);
        }

        public Task<Movie> UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
