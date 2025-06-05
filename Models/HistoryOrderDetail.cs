using System;
using System.Collections.Generic;

namespace office_equipment_repair.Models;

public partial class HistoryOrderDetail
{
    public int Id { get; set; }

    public int DetailId { get; set; }

    public DateOnly OrderDate { get; set; }

    public string Supplier { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual Detail Detail { get; set; } = null!;
}
