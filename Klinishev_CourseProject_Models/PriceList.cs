﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinishev_CourseProject_Models
{
    public class PriceList
    {
        [DisplayName("Уникальный номер")]
        public int Id { set; get; }
        [DisplayName("Название продукции")]
        public string Type { set; get; }
        [DisplayName("Цена за единицу продукта")]
        public int Price { set; get; }
    }
}
