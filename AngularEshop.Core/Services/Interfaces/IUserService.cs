using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularEshop.DataLayer.Entities.Account;
using AngularEshop.DataLayer.Repository;

namespace AngularEshop.Core.Services.Interfaces
{
    public interface  IUserService:IDisposable
    {
        Task<List<User>> GetAllUser();
    }
}
