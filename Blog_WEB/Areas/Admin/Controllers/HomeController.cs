using Blog_SERVİCE.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog_WEB.Areas.Admin.Controllers
{
    [Area("Admin")]     //Web katmanında iki tane homecontroler var hangisinin olduğunu belli etmeliyim bu şekilde yoksa karışacaktır.
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;

        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;
        }
        public async Task<IActionResult> Index()
        {
            var articles=await articleService.GetAllArticlesAsync();
            return View(articles);
        }
    }
}
