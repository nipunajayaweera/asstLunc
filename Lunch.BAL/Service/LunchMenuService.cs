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
    public class LunchMenuService : ILunchMenuService
    {
        private ILunchMenuRepo _lunchMenu;
        public LunchMenuService()
        {
            _lunchMenu = new LunchMenuRepo();
        }

        public List<string> GetAllType()
        {
            var ss =_lunchMenu.Get().Select(o=>o.Lunch1).ToList();
            return ss;
        }
    }
}
