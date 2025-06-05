using System;
using System.Collections.Generic;

namespace office_equipment_repair.Models;

public partial class Diagnostic
{
    public int Id { get; set; }

    public int TechnicId { get; set; }

    public DateOnly LastDiagnosticDate { get; set; }

    public DateOnly NextDiagnosticDate { get; set; }

    public int? ProblemId { get; set; }

    public virtual ICollection<HistoryDiagnostic> HistoryDiagnostics { get; set; } = new List<HistoryDiagnostic>();

    public virtual TypesProblem? Problem { get; set; }

    public virtual Technic Technic { get; set; } = null!;
}
