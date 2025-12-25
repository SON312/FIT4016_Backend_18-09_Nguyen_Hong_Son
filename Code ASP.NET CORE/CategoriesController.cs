using System.Collections.Generic;
using System.Runtime.InteropServices;
using CategoryAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CategoryAPI.Controllers
{
    // Đánh dấu đây là API Controller
    [ApiController]
    // Route mặc định: /api/categories
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        // Service được inject thông qua Dependency Injection
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET /api/categories
        // Lấy danh sách tất cả categories
        [HttpGet]
        public ActionResult<List<Category>> GetCategories()
        {
            var categories = _categoryService.GetAllCategories();
            return Ok(categories); // HTTP 200
        }

        // GET /api/categories/{id}
        // Lấy category theo id
        [HttpGet("{id}")]
        public ActionResult<Category> GetCategoryById(int id)
        {
            var category = _categoryService.GetCategoryById(id);

            // Nếu không tìm thấy category
            if (category == null)
            {
                return NotFound(); // HTTP 404
            }

            return Ok(category); // HTTP 200
        }

        // POST /api/categories
        // Tạo mới category
        [HttpPost]
        public ActionResult<Category> Create(Category category)
        {
            var createdCategory = _categoryService.CreateCategory(category);

            // Trả về HTTP 201 Created
            return CreatedAtAction(
                nameof(GetCategoryById),
                new { id = createdCategory.Id },
                createdCategory
            );
        }

        // PUT /api/categories/{id}
        // Cập nhật category theo id
        [HttpPut("{id}")]
        public ActionResult<Category> Update(int id, Category category)
        {
            var updatedCategory = _categoryService.UpdateCategory(id, category);

            // Nếu không tìm thấy category để update
            if (updatedCategory == null)
            {
                return NotFound(); // HTTP 404
            }

            return Ok(updatedCategory); // HTTP 200
        }

        // DELETE /api/categories/{id}
        // Xóa category theo id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool isDeleted = _categoryService.DeleteCategory(id);

            // Nếu không tìm thấy category để xóa
            if (!isDeleted)
            {
                return NotFound(); // HTTP 404
            }

            // Xóa thành công, không trả về dữ liệu
            return NoContent(); // HTTP 204
        }
    }
}