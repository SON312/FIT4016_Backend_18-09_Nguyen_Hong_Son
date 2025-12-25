using CategoryAPI;

namespace CategoryAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private static List<Category> _categories = new List<Category>
        {
            new Category { Id = 1, Name = "Electronics", Description = "Electronic devices", IsActive = true },
            new Category { Id = 2, Name = "Books", Description = "Books and novels", IsActive = true },
            new Category { Id = 3, Name = "Clothing", Description = "Fashion items", IsActive = true }
        };

        public List<Category> GetAllCategories()
        {
            return _categories;
        }

        public Category? GetCategoryById(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }

        public Category CreateCategory(Category category)
        {
            category.Id = _categories.Max(c => c.Id) + 1;
            _categories.Add(category);
            return category;
        }

        public Category? UpdateCategory(int id, Category updatedCategory)
        {
            var existing = GetCategoryById(id);
            if (existing == null)
            {
                return null;
            }

            existing.Name = updatedCategory.Name;
            existing.Description = updatedCategory.Description;
            existing.IsActive = updatedCategory.IsActive;

            return existing;
        }

        public bool DeleteCategory(int id)
        {
            var category = GetCategoryById(id);
            if (category == null)
            {
                return false;
            }

            _categories.Remove(category);
            return true;
        }
    }
}