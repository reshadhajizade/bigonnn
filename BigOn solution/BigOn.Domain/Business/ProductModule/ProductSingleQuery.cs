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

namespace BigOn.Domain.Application.ProductModule
{
    public class ProductSingleQuery:IRequest<Product>
    {
        public int id { get; set; }
        public class ProductSingleQueryHandler : IRequestHandler<ProductSingleQuery, Product>
        {
           
            private readonly BigOnDbContext db;

            public ProductSingleQueryHandler(BigOnDbContext db)
            {
                this.db = db;
            }
            public async Task<Product> Handle(ProductSingleQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Products.FirstOrDefaultAsync(m => m.Id == request.id && m.DeletedTime == null,cancellationToken);
                return data;
            }
        }
    }
}
