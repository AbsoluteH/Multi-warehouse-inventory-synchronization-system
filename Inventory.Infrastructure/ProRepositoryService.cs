using Inventory.Abstractions;
using Inventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure
{
    public class ProRepositoryService : IRepositoryService<ProductEntity>
    {
        Task<ProductEntity> IRepositoryService<ProductEntity>.AddAsync(ProductEntity entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        void IRepositoryService<ProductEntity>.Delete(ProductEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<ProductEntity> IRepositoryService<ProductEntity>.GetByIdAsync<TId>(TId id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<IReadOnlyList<ProductEntity>> IRepositoryService<ProductEntity>.ListAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        void IRepositoryService<ProductEntity>.Update(ProductEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
