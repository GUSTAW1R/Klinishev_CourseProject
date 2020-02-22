using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinishev_CourseProject_Models
{
    public class Deal
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int IdCustomer { set; get; }
        public DateTime DateStart { set; get; }
        public DateTime DateFinish { set; get; }
        public string Conditions { set; get; }

    }
}
