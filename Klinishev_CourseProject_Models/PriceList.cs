using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinishev_CourseProject_Models
{
    public class PriceList
    {
        public int Id { set; get; }
        public string Type { set; get; }
        public int Price { set; get; }
        public bool IsRival { set; get; }
    }
}
