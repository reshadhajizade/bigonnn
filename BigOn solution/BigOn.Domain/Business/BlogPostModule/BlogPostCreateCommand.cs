﻿using BigOn.Domain.AppCode.Extensions;
using BigOn.Domain.AppCode.Infrastructure;
using BigOn.Domain.Models.DataContexts;
using BigOn.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BigOn.Domain.Business.BlogPostModule
{
    public class BlogPostCreateCommand:IRequest<JsonResponse>
    {
        
        public string Title { get; set; }
        public string Body { get; set; }
        public int CategoryId { get; set; }
        public string ImagePath { get; set; }   
        public IFormFile Image { get; set; }
        public int[] TagIds { get; set; }   
        public class BlogPostCreateCommandHandler : IRequestHandler<BlogPostCreateCommand, JsonResponse>
        {
           
            private readonly BigOnDbContext db;
            private readonly IHostEnvironment env;

            public BlogPostCreateCommandHandler(BigOnDbContext db,IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(BlogPostCreateCommand request, CancellationToken cancellationToken)
            {

                var entity = new BlogPost();
                entity.TagCloud= new List<BlogPostTagItem>();
                entity.Title = request.Title;
                entity.Body = request.Body;
                entity.CategoryId = request.CategoryId;

                if (request.Image == null)
                    goto end;

                string extension = Path.GetExtension(request.Image.FileName);
                request.ImagePath = $"blogpost-{Guid.NewGuid().ToString().ToLower()}{extension}";
                string fullPath = env.GetImagePhysicalPath(request.ImagePath);
                using (var fs = new FileStream(fullPath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    request.Image.CopyTo(fs);
                }

                //var oldPath= env.GetImagePhysicalPath(entity.ImagePath);
                //if (System.IO.File.Exists(oldPath))
                //{
                //    System.IO.File.Delete(oldPath);
                //}
                

                entity.ImagePath = request.ImagePath;

            end:
                entity.Slug = request.Title.ToSlug();

            if (request.TagIds != null)
                {
                    foreach (var exceptedId in request.TagIds)
                    {
                        var tagItem = new BlogPostTagItem();
                        tagItem.TagId= exceptedId;
                       
                        entity.TagCloud.Add(tagItem);
                    }
                }
                await db.BlogPosts.AddAsync(entity, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);
               
                return new JsonResponse
                {
                    Error =false,
                    Message ="Success"
                };
            }
        }
    }
}
