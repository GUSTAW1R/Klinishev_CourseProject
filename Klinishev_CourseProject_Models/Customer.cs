using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinishev_CourseProject_Models
{
    public class Customer
    {
        [DisplayName("Уникальный номер")]
        public int Id { set; get; }
        [DisplayName("Имя заказчика")]
        public string FIO { set; get; }
        [DisplayName("Почтовый адрес заказчика")]
        public string Email { set; get; }
        [DisplayName("ИНН заказчика")]
        public string INN { set; get; }
    }
}
