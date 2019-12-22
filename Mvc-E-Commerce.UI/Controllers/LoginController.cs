using Mvc_E_Commerce.Entity.DTO;
using Mvc_E_Commerce.Entity.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using static Mvc_E_Commerce.BLL.Controller.MembershipTools;
namespace Mvc_E_Commerce.UI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult UserAdd()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterDTO model)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", model);
            }
            try
            {
                var userStore = NewUserStore();
                var userManager = NewUserManager();
                var roleManager = NewRoleManager();

                var user = await userManager.FindByNameAsync(model.UserName);
                if (user == null)
                {
                    ModelState.AddModelError("UserName", "Bu kullanıcı adı daha önceden alınmıştır");
                    return View("Index", model);
                }
                var newUser = new User()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Name = model.Name

                };
                var result = await userManager.CreateAsync(newUser, model.Password);
                if (result.Succeeded)
                {
                    if (userStore.Users.Count() == 1)
                    {
                        await userManager.AddToRoleAsync(newUser.Id,"Admin");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(newUser.Id, "User");
                    }
                }
                else
                {
                    var error = "";
                    foreach (var resultError in result.Errors)
                    {
                        error += resultError + " ";
                    }
                    ModelState.AddModelError("",result.Errors.ToString());
                    return View("Login",model);
                }
               return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
               return RedirectToAction("Error","Home");
            }

        }
    }
}