using System;
using System.Collections.Generic;

namespace office_equipment_repair.Models;

public partial class HistoryRepairDetail
{
    public int Id { get; set; }

    public int HistoryRepairId { get; set; }

    public int DetailId { get; set; }

    public int Quantity { get; set; }

    public virtual Detail Detail { get; set; } = null!;

    public virtual HistoryRepair HistoryRepair { get; set; } = null!;
}
