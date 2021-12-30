using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using System;
=======
>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechTreeMVCWebApplication.Data;
using TechTreeMVCWebApplication.Entities;
using TechTreeMVCWebApplication.Models;

namespace TechTreeMVCWebApplication.Controllers
{
    [Authorize]
    public class CategoriesToUserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IDataFunctions _dataFunctions;

        public CategoriesToUserController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IDataFunctions dataFunctions)
        {
            _context = context;
            _userManager = userManager;
            _dataFunctions = dataFunctions;
        }
        public async Task<IActionResult> Index()
        {
            CategoriesToUserModel categoriesToUserModel = new CategoriesToUserModel();

            var userId = _userManager.GetUserAsync(User).Result?.Id;

            categoriesToUserModel.Categories = await GetCategoriesThatHaveContent();

            categoriesToUserModel.CategoriesSelected = await GetCategoriesCurrentlySavedForUser(userId);

            categoriesToUserModel.UserId = userId;

            return View(categoriesToUserModel);
<<<<<<< HEAD
        }

=======

        }
>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string[] categoriesSelected)
        {
            var userId = _userManager.GetUserAsync(User).Result?.Id;

            List<UserCategory> userCategoriesToDelete = await GetCategoriesToDeleteForUser(userId);
<<<<<<< HEAD
            List<UserCategory> userCategoriesToAdd =  GetCategoriesToAddForUser(categoriesSelected, userId);
=======

            List<UserCategory> userCategoriesToAdd = GetCategoriesToAddForUser(categoriesSelected, userId);
>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67

            await _dataFunctions.UpdateUserCategoryEntityAsync(userCategoriesToDelete, userCategoriesToAdd);

            return RedirectToAction("Index", "Home");
<<<<<<< HEAD
=======

>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
        }

        private async Task<List<Category>> GetCategoriesThatHaveContent()
        {
            var categoriesThatHaveContent = await (from category in _context.Category
                                                   join categoryItem in _context.CategoryItem
                                                   on category.Id equals categoryItem.CategoryId
                                                   join content in _context.Content
                                                   on categoryItem.Id equals content.CategoryItem.Id
                                                   select new Category
                                                   {
                                                       Id = category.Id,
                                                       Title = category.Title,
                                                       Description = category.Description
<<<<<<< HEAD
                                                   }).Distinct().ToListAsync();

            return categoriesThatHaveContent;
        }
=======

                                                   }).Distinct().ToListAsync();
            return categoriesThatHaveContent;

        }

>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
        private async Task<List<Category>> GetCategoriesCurrentlySavedForUser(string userId)
        {
            var categoriesCurrentlySavedForUser = await (from userCategory in _context.UserCategory
                                                         where userCategory.UserId == userId
                                                         select new Category
                                                         {
<<<<<<< HEAD
                                                             Id = userCategory.CategoryId,
                                                         }).ToListAsync();
            return categoriesCurrentlySavedForUser;
        }
=======
                                                             Id = userCategory.CategoryId
                                                         }).ToListAsync();
            return categoriesCurrentlySavedForUser;

        }

>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
        private async Task<List<UserCategory>> GetCategoriesToDeleteForUser(string userId)
        {
            var categoriesToDelete = await (from userCat in _context.UserCategory
                                            where userCat.UserId == userId
                                            select new UserCategory
                                            {
                                                Id = userCat.Id,
                                                CategoryId = userCat.CategoryId,
                                                UserId = userId
                                            }).ToListAsync();
<<<<<<< HEAD

=======
>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
            return categoriesToDelete;
        }

        private List<UserCategory> GetCategoriesToAddForUser(string[] categoriesSelected, string userId)
        {
            var categoriesToAdd = (from categoryId in categoriesSelected
                                   select new UserCategory
                                   {
                                       UserId = userId,
                                       CategoryId = int.Parse(categoryId)
                                   }).ToList();
<<<<<<< HEAD

            return categoriesToAdd;
                
        }

=======
            return categoriesToAdd;

        }
>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
    }
}
