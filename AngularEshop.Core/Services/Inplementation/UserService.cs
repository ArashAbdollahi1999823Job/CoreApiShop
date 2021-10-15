using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularEshop.Core.Services.Interfaces;
using AngularEshop.DataLayer.Entities.Account;
using AngularEshop.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace AngularEshop.Core.Services.Inplementation
{
    public class UserService:IUserService
    {

        #region ctor

        private IGenericRepository<User> _useRepository;

        public UserService(IGenericRepository<User> useRepository)
        {
            _useRepository = useRepository;
        }

        #endregion


        #region dispose

        public void Dispose()
        {
            _useRepository?.Dispose();
        }
        #endregion


        #region UserSection

        public async Task<List<User>> GetAllUser()
        {
            return await _useRepository.GetEntitiesQuery().ToListAsync();
        }
        #endregion

    }
}
