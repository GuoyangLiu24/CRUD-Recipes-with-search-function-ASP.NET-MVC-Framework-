﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models.ViewModels;
using System.Threading.Tasks;

namespace Recipes.Controllers
{
        [Authorize]
        public class AccountController : Controller
        {
            private UserManager<IdentityUser> userManager;
            private SignInManager<IdentityUser> signInManager;
            public AccountController(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signMgr)
            {
                userManager = userMgr;
                signInManager = signMgr;
            }

            [AllowAnonymous]
            public ViewResult Login(string returnUrl)
            {
                return View(new LoginModel { ReturnUrl = returnUrl });
            }

            [HttpPost]
            [AllowAnonymous]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Login(LoginModel loginModel)
            {
                if (ModelState.IsValid)
                {
                    IdentityUser user = await userManager.FindByNameAsync(loginModel.Name);
                    if (user != null)
                    {
                        if ((await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).Succeeded)
                        {
                            return Redirect(loginModel?.ReturnUrl ?? "/Admin/Index");
                        }
                    }
                }
                ModelState.AddModelError("", "Invalide name or password");
                return View(loginModel);
            }

            public async Task<RedirectResult> Logout(string returnUrl = "/")
            {
                await signInManager.SignOutAsync();
                return Redirect(returnUrl);
            }
        }
    }

