using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunch.Common
{
    public class HomeModel
    {
        public List<string> Lunch { get; set; }
        public List<string> LunchPlace { get; set; }
        public List<string> Transport { get; set; }
        public List<string> LeaveTime { get; set; }
    }
}
