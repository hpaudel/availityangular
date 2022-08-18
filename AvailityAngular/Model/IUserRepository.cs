using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvailityAngular.Model
{
    interface IUserRepository
    {
        public User Add(User user);
    }
}
