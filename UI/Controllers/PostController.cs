using Businness.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
   
    public class PostController : Controller
    {
        IPostService postService;
        IUserService userService;
        public PostController(IPostService postService, IUserService userService)
        {
            this.postService = postService;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated==true)
            {
                return RedirectToAction("Login", "User");
            }
            List<Post> posts = postService.GetAll();
            return View(posts);
        }

        public IActionResult CreatePost()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(CreatePostViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = userService.GetAll().FirstOrDefault(x => x.Name == model.Name);
                if (user == null)
                {
                    return NotFound();
                }
                postService.Add(new Post()
                {
                    Description= model.Description,
                    CreatedBy= user.Id,
                    CreatedAt= DateTime.Now,
                    UserId = user.Id
                    

                });
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
