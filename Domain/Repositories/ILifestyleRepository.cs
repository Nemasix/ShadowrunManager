using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ILifestyleRepository
    {
        Task<IEnumerable<Lifestyle>> GetAllByIdentityAsync(Guid identityId,CancellationToken cancellationToken = default(CancellationToken));
        Task<Lifestyle> GetByIdAsync(Guid lifestyleId, CancellationToken cancellationToken = default(CancellationToken));
        void Add(Lifestyle lifestyle);
        void Delete(Guid Id);
    
    }
}