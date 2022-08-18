using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvailityAngular.Model
{
    public class UserRepository : IUserRepository
    {
        
        private readonly AppDBContext context;

        public UserRepository(AppDBContext context)
        {
            this.context = context;
        }
        public User Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }
    }
}
