using Projects.BLL.Interfaces;
using Projects.DAL.Interfaces;
using Projects.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Services
{
    public class UserService : GenericService<User>, IUserService
    {
        public UserService(IUserRepository context) : base(context) { }
    }
}
