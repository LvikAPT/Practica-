using System;
using System.Collections.Generic;

namespace office_equipment_repair.Models;

public partial class HistoryRepair
{
    public int Id { get; set; }

    public int TechnicId { get; set; }

    public DateOnly RepairDate { get; set; }

    public string? WorkDone { get; set; }

    public virtual Technic Technic { get; set; } = null!;
}
