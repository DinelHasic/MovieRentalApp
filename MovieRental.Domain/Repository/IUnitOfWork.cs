using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Domain.Repository
{
    public interface IUnitOfWork
    {
        Task<int> SavaChangesAsync();
    }
}
