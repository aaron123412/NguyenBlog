using NguyenBlog.Data;
using NguyenBlog.Data.Models;
using NguyenBlog.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace NguyenBlog.Service
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public UserService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public ApplicationUser Get(string id)
        {
            return applicationDbContext.Users.FirstOrDefault(user => user.Id == id);
        }
        public async Task<ApplicationUser> Update(ApplicationUser applicationUser)
        {
            applicationDbContext.Users.Update(applicationUser);
            await applicationDbContext.SaveChangesAsync();
            return applicationUser;
        }
    }
}
