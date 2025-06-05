using System;
using System.Collections.Generic;

namespace office_equipment_repair.Models;

public partial class HistoryRepair
{
    public int Id { get; set; }

    public int TechnicId { get; set; }

    public DateOnly RepairDate { get; set; }

    public string? WorkDone { get; set; }

    // Removed WorkTypeId property
    // public int? WorkTypeId { get; set; }

    public virtual ICollection<HistoryRepairDetail> HistoryRepairDetails { get; set; } = new List<HistoryRepairDetail>();

    public virtual Technic Technic { get; set; } = null!;

    // Removed WorkType navigation property
    // public virtual TypesWork? WorkType { get; set; }
}
