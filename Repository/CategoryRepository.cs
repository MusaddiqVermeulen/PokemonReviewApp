using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _context;
        public CategoryRepository(DataContext context)
        {
            _context = context;
        }
        public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);    // we're bringing in our context(the code that sits on top of the database and returns what you ask for)
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
        

        public Category GetCategories(int id)
        {
            return _context.Categories.Where(e => e.Id == id).FirstOrDefault();     // when it's returning one it should have that FirstOrDefault
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(e => e.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(e => e.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
        }
    }
}
