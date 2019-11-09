using meu_blog_netcore.Models;
using meu_blog_netcore.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace meu_blog_netcore.Controllers
{
    public class CategoryController:Controller
    {
        private CategoryRepository _categoryRepository;
        public CategoryController(IConfiguration configuration){
            this._categoryRepository = new CategoryRepository(configuration);
        }


        [HttpGet]
        public ActionResult Index(){

            var category = new Category("Teste");
            
            return View ();
        }
    }
}