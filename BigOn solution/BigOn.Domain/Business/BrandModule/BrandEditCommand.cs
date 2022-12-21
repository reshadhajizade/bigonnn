using BigOn.Domain.Models.DataContexts;
using BigOn.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BigOn.Domain.Application.BrandModule
{
   public class BrandEditCommand:IRequest<Brand>
    {
        public int id { get; set; }
        public string Name { get; set; }    
        public class BrandEditCommandHandler : IRequestHandler<BrandEditCommand, Brand>
        {
           
            private readonly BigOnDbContext db;

            public BrandEditCommandHandler(BigOnDbContext db)
            {
                this.db = db;
            }
            public async Task<Brand> Handle(BrandEditCommand request, CancellationToken cancellationToken)
            {
                var data = await db.Brands
                    .FirstOrDefaultAsync(m => m.Id == request.id && m.DeletedTime == null,cancellationToken);
                if (data == null)
                {
                    return null;
                }
                
                data.Name = request.Name;
                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}
