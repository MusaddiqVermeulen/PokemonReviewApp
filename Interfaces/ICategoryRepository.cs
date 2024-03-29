﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExists(int id);    // we're not using it to return data, we're using it to check if something exists
        bool CreateCategory(Category category);  // creating our signatures(create methods)
        bool UpdateCategory(Category category); // updating 
        bool DeleteCategory(Category category);  // used for deleting
        bool Save();
    }
}
