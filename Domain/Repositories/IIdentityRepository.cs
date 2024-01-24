using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IIdentityRepository
    {
        Task<IEnumerable<Identity>> GetAllByCharacterAsync(Guid characterId, CancellationToken cancellationToken = default(CancellationToken));
        Task<Identity> GetByIdAsync(Guid identityId, CancellationToken cancellationToken = default(CancellationToken));
        void Add(Identity identity);
        void Delete(Guid Id);
    }
}