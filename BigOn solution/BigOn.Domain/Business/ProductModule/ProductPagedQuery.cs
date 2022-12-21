using BigOn.Domain.AppCode.Infrastructure;
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
    public class ProductPagedQuery: PaginateModel, IRequest<PagedViewModel<Product>>
    {
        public class ProductPagedQueryHandler : IRequestHandler<ProductPagedQuery, PagedViewModel<Product>>
        {
            private readonly BigOnDbContext db;

            public ProductPagedQueryHandler(BigOnDbContext db)
            {
                this.db = db;
            }
            public  async Task<PagedViewModel<Product>> Handle(ProductPagedQuery request, CancellationToken cancellationToken)
            {
                var query =  db.Products
                    .Include(p=>p.Images)
                    .Include(p=>p.Brand)
                    .Include(p => p.Category)
                    .Where(m => m.DeletedTime == null)
                    .OrderByDescending(p=>p.Id)
                    .AsQueryable();
                var pagetData= new PagedViewModel<Product>(query,request);
                return pagetData;
            }
        }
    }
}
