using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinishev_CourseProject_Models
{
    public class Deal
    {
        [DisplayName("Уникальный номер")]
        public int Id { set; get; }
        [DisplayName("Название договора")]
        public string Name { set; get; }
        [DisplayName("Номер заказчика")]
        public int IdCustomer { set; get; }
        [DisplayName("Дата заклбчения договора")]
        public DateTime DateStart { set; get; }
        [DisplayName("Дата рассторжения договора")]
        public DateTime DateFinish { set; get; }
        [DisplayName("Условия договора")]
        public string Conditions { set; get; }

    }
}
