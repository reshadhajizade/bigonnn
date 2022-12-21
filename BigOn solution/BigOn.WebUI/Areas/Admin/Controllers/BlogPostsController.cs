using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BigOn.Domain.Models.DataContexts;
using BigOn.Domain.Models.Entities;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using BigOn.Domain.AppCode.Extensions;
using BigOn.Domain.Business.BlogPostModule;
using MediatR;

namespace BigOn.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogPostsController : Controller
    {
        private readonly BigOnDbContext db;
        private readonly IHostEnvironment env;
        private readonly IMediator mediator;

        public BlogPostsController(BigOnDbContext context,IHostEnvironment env,IMediator mediator)
        {
            db = context;
            this.env = env;
            this.mediator = mediator;
        }

        // GET: Admin/BlogPosts
        public async Task<IActionResult> Index()
        {
            var data = await db.BlogPosts
                //.Include(bp=>bp.Category)
                //.Include(bp => bp.TagCloud)
                //.ThenInclude(bp => bp.Tag)
                .Where(bp=>bp.DeletedTime==null)
                .ToListAsync();
            return View(data);
        }

        // GET: Admin/BlogPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPost = await db.BlogPosts

                 .Include(bp => bp.Category)
                .Include(bp => bp.TagCloud)
                .ThenInclude(bp => bp.Tag)
            .FirstOrDefaultAsync(m => m.Id == id);
            if (blogPost == null)
            {
                return NotFound();
            }

            return View(blogPost);
        }

        // GET: Admin/BlogPosts/Create
        public IActionResult Create()
        {

            ViewBag.CategoryId = new SelectList(db.Categories.Where(t => t.DeletedTime == null).ToList(), "Id", "Name");
            ViewBag.Tags = new SelectList(db.Tags.Where(t => t.DeletedTime == null).ToList(), "Id", "Text");
            return View();
        }

        // POST: Admin/BlogPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( BlogPostCreateCommand command)
        {
            if (command.Image == null)
            {
                ModelState.AddModelError("ImagePath","Shekil gonderilmelidir!!");

            }
            if (ModelState.IsValid)
            {
                var response = await mediator.Send(command);
                if (response.Error==false)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewBag.CategoryId = new SelectList(db.Categories.ToList(), "Id", "Name",command.CategoryId);
            ViewBag.Tags = new SelectList(db.Tags.Where(t => t.DeletedTime == null).ToList(), "Id", "Text");
            return View(command);
        }

        // GET: Admin/BlogPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPost = await db.BlogPosts
                
                .Include(bp=>bp.TagCloud)
                .FirstOrDefaultAsync(bp=>bp.Id==id);
            if (blogPost == null)
            {
                return NotFound();
            }

            ViewBag.CategoryId = new SelectList(db.Categories.ToList(), "Id", "Name", blogPost.CategoryId);
            ViewBag.Tags = new SelectList(db.Tags.Where(t=>t.DeletedTime==null).ToList(), "Id", "Text");
            var editCommand = new BlogPostEditCommand();
            editCommand.Id = blogPost.Id;
            editCommand.Title = blogPost.Title;
            editCommand.ImagePath = blogPost.ImagePath;
            editCommand.Body = blogPost.Body;
            editCommand.CategoryId = blogPost.CategoryId;
            editCommand.TagIds = blogPost.TagCloud.Select(tc=>tc.TagId).ToArray();


            return View(editCommand);
        }

        // POST: Admin/BlogPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BlogPostEditCommand command)
        {
            if (id != command.Id)
            {
                return NotFound();
            }
            var response = await mediator.Send(command);
            if (response==null)
            {
                return NotFound();
            }
            if (response.Error==false)
            {
                return RedirectToAction(nameof(Index));
            }
            ViewBag.CategoryId = new SelectList(db.Categories.ToList(), "Id", "Name", command.CategoryId);
            ViewBag.Tags = new SelectList(db.Tags.Where(t => t.DeletedTime == null).ToList(), "Id", "Text");

            
            return View(command);
        }

   

        // POST: Admin/BlogPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entity = await db.BlogPosts
                     .FirstOrDefaultAsync(bp => bp.Id == id && bp.DeletedTime == null);

            if (entity == null)
            {
                return NotFound();

            }
            entity.DeletedTime = DateTime.UtcNow.AddHours(4);
            
            env.ArchiveImage(entity.ImagePath);

            
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogPostExists(int id)
        {
            return db.BlogPosts.Any(e => e.Id == id);
        }
    }
}
