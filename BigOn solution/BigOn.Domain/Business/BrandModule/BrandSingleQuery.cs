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
    public class BrandSingleQuery:IRequest<Brand>
    {
        public int id { get; set; }
        public class BrandSingleQueryHandler : IRequestHandler<BrandSingleQuery, Brand>
        {
           
            private readonly BigOnDbContext db;

            public BrandSingleQueryHandler(BigOnDbContext db)
            {
                this.db = db;
            }
            public async Task<Brand> Handle(BrandSingleQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Brands.FirstOrDefaultAsync(m => m.Id == request.id && m.DeletedTime == null,cancellationToken);
                return data;
            }
        }
    }
}
