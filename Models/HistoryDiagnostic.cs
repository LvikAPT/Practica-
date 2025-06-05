using System;
using System.Collections.Generic;

namespace office_equipment_repair.Models;

public partial class HistoryDiagnostic
{
    public int Id { get; set; }

    public int DiagnosticId { get; set; }

    public DateOnly DiagnosticDate { get; set; }

    public virtual Diagnostic Diagnostic { get; set; } = null!;
}
