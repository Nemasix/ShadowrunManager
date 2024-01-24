using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IRepositoryManager
    {
        IUnitOfWork UnitOfWork { get; }
        ICharacterRepository Character { get; }
        ILifestyleRepository Lifestyle { get; }
        IIdentityRepository Identity { get; }
    }
}