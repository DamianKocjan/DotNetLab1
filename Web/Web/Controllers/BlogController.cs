using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class BlogController : Controller
    {
        private static readonly List<BlogArticleViewModel> _articles = new()
        {
            new BlogArticleViewModel() { Title = "First Post", Description = "This is the first post on my blog." },
            new BlogArticleViewModel() { Title = "Second Post", Description = "This is the second post on my blog." },
            new BlogArticleViewModel() { Title = "Third Post", Description = "This is the third post on my blog." }
        };

        public IActionResult Article(int id)
        {
            var article = _articles.FirstOrDefault(a => a.Id == id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        public IActionResult Index()
        {
            return View(_articles);
        }
    }
}
