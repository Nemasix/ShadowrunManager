using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ICharacterRepository
    {
        Task<IEnumerable<Character>> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<Character> GetByIdAsync(Guid characterId, CancellationToken cancellationToken = default(CancellationToken));
        void Add(Character character);
        void Delete(Guid Id);

    }
}