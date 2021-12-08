using Pau.Core.DataAccess.Concrete.EntityFramework;
using Pau.DataAccess.Abstract;
using Pau.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pau.DataAccess.Concrete
{
    public class UserRepository : EfEntityRepositoryBase<PauDbContext,User>,IUserRepository
    {
        
    }
}
