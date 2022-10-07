using BigOn.Domain.AppCode.Extensions;
using BigOn.Domain.Models.DataContexts;
using BigOn.Domain.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace BigOn.Domain.Controllers
{
    public class HomeController : Controller
    {
        public BigOnDbContext Db { get; }
        private readonly IConfiguration configuration;
        public HomeController(BigOnDbContext db,IConfiguration configuration)
        {
            Db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactPost model)
        {
            if (ModelState.IsValid)
            {
                Db.ContactPosts.Add(model);
                Db.SaveChanges();
                //  ViewBag.Message = "Muracietiniz qeyde alindi!";
                // ModelState.Clear();
                //return View();
                var response = new
                {
                    error= false,
                    message= "Muracietiniz qeyde alindi!"
                };
                return Json(response);

              
            }
            var errorResponse = new
            {
                error = true,
                message = "Melumatlar uygun deyil!",
                state = ModelState.GetErrors()
            };
            return Json(errorResponse);
        }
        public IActionResult Faq()

        {
            var data = Db.Faqs.Where(f => f.DeletedDate==null).ToList();
            return View(data);
        }
       
        [HttpPost]
        public IActionResult Subscribe(Subscribe model)
        {
            if (!ModelState.IsValid)
            {
                string msg = ModelState.Values.First().Errors[0].ErrorMessage;
                return Json(new
                {
                    error= true,
                    message= msg,
                });
            }
            var entity= Db.Subscribes.FirstOrDefault(s=>s.Email.Equals(model.Email));

            if (entity == null && entity.IsApproved==true)
            {
                return Json(new
                {
                    error = true,
                    message = "siz artig abune olmusunuz"
                });
            }
            if (entity == null)
            {
                Db.Subscribes.Add(model);
                Db.SaveChanges();
            }
            else if (entity != null)
            {
                entity.Id=model.Id;

            }
            string token = $"{model.Id}--{model.Email}--{Guid.NewGuid()}".Encrypt(Program.key);
              token=   HttpUtility.UrlEncode(token);
            string message = $"Abuneliyinizi <a href='https://localhost:44323/approve-subscribe?'>link<a/> vasitesile tesdiq edin";
            configuration.SendMail("rashadah@code.edu.az",message,"readsds");
            return Json(new
            {
                error = false,
                message = "Emailinize tesdiq metni gonderdik"
            });
        }

        [Route("/approve-subscribe")]
        public string SubscribeApprove(string token)
        {
            token= token.Decrypt(Program.key);
           Match match = Regex.Match(token, @"^(?<id>\d+)-(?<email>[^-]+)-(?<randomkey>.*)$");
            if (!match.Success)
            {
                return "Token uygun deyil";
            }
            int id = Convert.ToInt32(match.Groups["id"].Value);
            string email =match.Groups["email"].Value;
            string randomkey = match.Groups["randomKey"].Value;
            var entity = Db.Subscribes.FirstOrDefault(s=>s.Id==id);
            if (entity==null)
            {
                return "tapilmadi";
            }
            if (entity.IsApproved)
            {
                return "Artiq tesdiq edilib";
            }
            entity.IsApproved = true;
            entity.ApprovedDate = DateTime.UtcNow.AddHours(4);
            Db.SaveChanges();
            return $"Id:{id} | Email:{email} | Randomkey:{randomkey}";
        }
    }
    }
