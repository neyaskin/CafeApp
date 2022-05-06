using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeWpfApp
{
    public class Helper
    {
        public static CafeDbContext db = new CafeDbContext();
        public static User userSession;
    }
}
