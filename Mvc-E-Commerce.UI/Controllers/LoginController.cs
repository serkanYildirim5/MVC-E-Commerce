using Microsoft.AspNet.Identity;
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
                if (user != null)
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
                //ümit hocaya extensions sorr
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LoginControl(LoginDTO loginDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Index", loginDTO);
                }
                var userManager = NewUserManager();
                var user =userManager.Find(loginDTO.UserName,loginDTO.Password);
                if (user==null)
                {
                    ModelState.AddModelError("","Kullanıcı Adı veya şifre hatalı");
                }
                var authManager = HttpContext.GetOwinContext().Authentication;
                var userIdentity = await userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                authManager.SignIn(new Microsoft.Owin.Security.AuthenticationProperties() {
                    IsPersistent=loginDTO.RememberMe//tarayıcının bizi hatırlaması için
                },userIdentity);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home");
            }
           
        }
        [HttpGet]
        public ActionResult LogOut()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            return RedirectToAction("Login");
        }
    }
}