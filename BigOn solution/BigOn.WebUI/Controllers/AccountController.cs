using BigOn.Domain.Models.Entities.Membership;
using BigOn.Domain.Models.FormModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BigOn.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<BigOnUser> signInManager;
        private readonly UserManager<BigOnUser> userManager;

        public AccountController(SignInManager<BigOnUser>signInManager,
            UserManager<BigOnUser>userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        [AllowAnonymous]
        [Route("/signin.html")]
        public IActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("/signin.html")]
        public async Task<IActionResult> Signin(UserFormModel model)
        {
            if (!model.IsValid())
                goto end;
            var user =  await userManager.FindByEmailAsync(model.Username);

            if (user == null)
            {
                ModelState.AddModelError("Username", "Istifadeci adiniz veya shifre sehvdir");
                goto end;
            }

            var result = await signInManager.PasswordSignInAsync(user, model.Password, true,true);
                
             if (result.IsNotAllowed)
            {
                ModelState.AddModelError("Username", "Sizin girish icazeniz yoxdur");
                goto end;
            }
            else if (result.IsLockedOut)
            {
                ModelState.AddModelError("Username", "5 deq sonra yeniden yoxlayin");
                goto end;
            }
           var redirectUrl= Request.Query["ReturnUrl"];

            if (!string.IsNullOrWhiteSpace(redirectUrl))
            {
                return Redirect(redirectUrl);
            }

            return RedirectToAction("Index", "Home");
        end:
            return View(model);
        }
    }
}
