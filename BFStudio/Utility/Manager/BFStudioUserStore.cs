using BFStudio.Entity;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BFStudio.Utility.Manager
{
    public class BFStudioUserStore : IUserStore<MST_USER>, IUserPasswordStore<MST_USER>
    {
        public Task CreateAsync(MST_USER user)
        {
            throw new NotImplementedException();
        }
        public Task DeleteAsync(MST_USER user)
        {
            throw new NotImplementedException();
        }
        public Task<MST_USER> FindByIdAsync(string userId)
        {
            using (var ent = new DBManageEntities())
            {
                var user = ent.MST_USER.SingleOrDefault(p => p.LOGIN_ID == userId);
                return Task.FromResult(user);
            }
        }
        public Task<MST_USER> FindByNameAsync(string userName)
        {
            using (var ent = new DBManageEntities())
            {
                var user = ent.MST_USER.SingleOrDefault(p => p.LOGIN_ID == userName);
                return Task.FromResult(user);
            }
        }
        public Task UpdateAsync(MST_USER user)
        {
            throw new NotImplementedException();
        }



        public Task<string> GetPasswordHashAsync(MST_USER user)
        {
            return Task.FromResult(user.PASSWORD);
        }
        public Task<bool> HasPasswordAsync(MST_USER user)
        {
            throw new NotImplementedException();
        }
        public Task SetPasswordHashAsync(MST_USER user, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //例外は出ないようにNotImplementedExceptionは消しておく
        }
    }
}