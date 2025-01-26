using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework__ORM_
{
    public class GenreService : IGenreService
    {
        public void Create(Genre genre)
        {
            AppDbContext context = new AppDbContext();
            context.Genres.Add(genre);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            AppDbContext context = new AppDbContext();
            var genre = context.Genres.FirstOrDefault(g => g.Id == id);

            if (genre is null) throw new NullReferenceException("Genre not found.");

            context.Genres.Remove(genre);
            context.SaveChanges();
        }

        public List<Genre> GetAll()
        {
            List<Genre> allGenres = new List<Genre>();

            AppDbContext context = new AppDbContext();
            allGenres = context.Genres.ToList();

            return allGenres;
        }

        public Genre GetById(int id)
        {
            AppDbContext context = new AppDbContext();
            var genre = context.Genres.FirstOrDefault(g => g.Id == id);

            if (genre is null) throw new NullReferenceException("Genre not found.");

            return genre;
        }

        public void Update(int id, Genre genre)
        {
            AppDbContext context = new AppDbContext();

            var existGenre = context.Genres.FirstOrDefault(g => g.Id == id);

            if (existGenre is null) throw new NullReferenceException("Genre not found.");
            existGenre.Name = genre.Name;

            context.SaveChanges();
            
        }
    }
}
