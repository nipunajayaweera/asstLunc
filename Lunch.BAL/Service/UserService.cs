using Lunch.BAL.IService;
using Lunch.DAL.IRepository;
using Lunch.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunch.BAL.Service
{
    public class UserService : IUserService
    {
        private UserRepo _userRepo;

        public UserService()
        {
            _userRepo = new UserRepo();
        }

        public string GetUserName(int id)
        {
            var user = _userRepo.GetById(id);
            return user.FirstName + " " + user.LastName;
        }
    }
}
