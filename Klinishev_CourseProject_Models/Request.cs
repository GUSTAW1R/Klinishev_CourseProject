using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinishev_CourseProject_Models
{
    public class Request
    {
        [DisplayName("Уникальный номер")]
        public int Id { set; get; }
        [DisplayName("Номер поставщика")]
        public int IdCustomer { set; get; }
        [DisplayName("Тип продукции")]
        public string Type { set; get; }
        [DisplayName("Количество продукции")]
        public int Count { set; get; }
        [DisplayName("Дата составления заявки")]
        public DateTime Date { set; get; }
    }
}
