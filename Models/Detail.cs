using System;
using System.Collections.Generic;

namespace office_equipment_repair.Models;

public partial class Detail
{
    public int Id { get; set; }

    public string DetailName { get; set; } = null!;

    public int Quantity { get; set; }

    public virtual ICollection<HistoryOrderDetail> HistoryOrderDetails { get; set; } = new List<HistoryOrderDetail>();

    public virtual ICollection<HistoryRepairDetail> HistoryRepairDetails { get; set; } = new List<HistoryRepairDetail>();
}
