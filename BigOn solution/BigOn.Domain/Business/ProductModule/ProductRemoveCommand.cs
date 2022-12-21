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
    public class ProductRemoveCommand : IRequest<Product>
    {
        public int id { get; set; }
        public string Name { get; set; }
        public class ProductRemoveCommandHandler : IRequestHandler<ProductRemoveCommand, Product>
        {

            private readonly BigOnDbContext db;

            public ProductRemoveCommandHandler(BigOnDbContext db)
            {
                this.db = db;
            }
            public async Task<Product> Handle(ProductRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = await db.Products
                    .FirstOrDefaultAsync(m => m.Id == request.id && m.DeletedTime == null, cancellationToken);
                if (data == null)
                {
                    return null;
                }

                data.DeletedTime = DateTime.UtcNow.AddHours(4);
                await db.SaveChangesAsync(cancellationToken);
                return data;
            }

           
        }
    }
}
