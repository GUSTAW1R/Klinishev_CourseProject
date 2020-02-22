using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinishev_CourseProject_Models
{
    public class Request
    {
        public int Id { set; get; }
        public int IdCustomer { set; get; }
        public string Type { set; get; }
        public int Count { set; get; }
        public DateTime Date { set; get; }
    }
}
