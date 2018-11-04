using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunch.DAL
{
    public class DBContext
    {
        private static ASSTDBContext instance = null;
        private DBContext() {}

        public static ASSTDBContext GetInstance()
        {
            if (instance == null)
            {
                instance = new ASSTDBContext();
            }

            return instance;
        }
    }
}
