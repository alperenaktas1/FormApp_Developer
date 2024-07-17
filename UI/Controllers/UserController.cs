using Businness.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class UserController : Controller
    {
        IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            List<User> userList = userService.GetAll();
            foreach (var item in userList)
            {
                if (item.Name == model.Name && item.Password == item.Password)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();

        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel model, string password)
        {
            if (ModelState.IsValid)
            {

                List<User> userList = userService.GetAll();
                foreach (var item in userList)
                {
                    if (item.Name == model.Name)
                    {
                        return View();
                    }
                }

                User user = new()
                {
                    Name = model.Name,
                    Password= password,
                };
                
                userService.Add(user);
                return RedirectToAction("Login", "User");
            }
            return View(model);
        }
    }
}
