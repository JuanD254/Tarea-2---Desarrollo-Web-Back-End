﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Tarea_2___Desarrollo_Web_Back_End.DataAccess
{
    public partial class SummaryOfSalesByYear
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
