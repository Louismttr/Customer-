using System;
using System.Collections.Generic;

namespace pjSistematico.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
