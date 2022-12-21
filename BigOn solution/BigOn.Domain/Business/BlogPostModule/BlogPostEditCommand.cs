using BigOn.Domain.AppCode.Extensions;
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
    public class BlogPostEditCommand:IRequest<JsonResponse>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int CategoryId { get; set; }
        public string ImagePath { get; set; }   
        public IFormFile Image { get; set; }
        public int[] TagIds { get; set; }   
        public class BlogPostEditCommandHandler : IRequestHandler<BlogPostEditCommand, JsonResponse>
        {
           
            private readonly BigOnDbContext db;
            private readonly IHostEnvironment env;

            public BlogPostEditCommandHandler(BigOnDbContext db,IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(BlogPostEditCommand request, CancellationToken cancellationToken)
            {

                var entity = await db.BlogPosts
                    .Include(bp => bp.TagCloud)
                     .FirstOrDefaultAsync(bp => bp.Id == request.Id && bp.DeletedTime == null);

                if (entity == null)
                {
                    return null;

                }

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
                env.ArchiveImage(entity.ImagePath);

                entity.ImagePath = request.ImagePath;

            end:
                if (string.IsNullOrWhiteSpace(entity.Slug))
                {
                    entity.Slug = request.Title.ToSlug();
                }

                if (request.TagIds == null && entity.TagCloud.Any())
                {
                    foreach (var tagItem in entity.TagCloud)
                    {
                        db.BlogPostTagCloud.Remove(tagItem);
                    }
                }
                else if (request.TagIds != null)
                {
                    var exceptedIds = db.BlogPostTagCloud.Where(tc => tc.BlogPostId == entity.Id).Select(tc => tc.TagId).ToList()
                         .Except(request.TagIds).ToArray();

                    if (exceptedIds.Length > 0)
                    {
                        foreach (var exceptedId in exceptedIds)
                        {
                            var tagItem = db.BlogPostTagCloud.FirstOrDefault(tc => tc.TagId == exceptedId &&
                            tc.BlogPostId == entity.Id);
                            if (tagItem != null)
                            {
                                db.BlogPostTagCloud.Remove(tagItem);
                            }
                        }
                    }

                    var newExceptedIds = request.TagIds.Except(db.BlogPostTagCloud.Where(tc => tc.BlogPostId == entity.Id).Select(tc => tc.TagId).ToList()).ToArray();
                    if (newExceptedIds.Length > 0)
                    {
                        foreach (var exceptedId in exceptedIds)
                        {
                            var tagItem = new BlogPostTagItem();
                            tagItem.Id = exceptedId;
                            tagItem.BlogPostId = entity.Id;
                           await db.BlogPostTagCloud.AddAsync(tagItem);
                        }
                    }
                }

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
