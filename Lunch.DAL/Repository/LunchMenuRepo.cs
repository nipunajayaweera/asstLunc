using Lunch.DAL.Common;
using Lunch.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunch.DAL.Repository
{
    public class LunchMenuRepo : GenericRepository<Lunch>,ILunchMenuRepo
    {
    }
}
