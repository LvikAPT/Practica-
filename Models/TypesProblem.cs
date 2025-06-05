using System;
using System.Collections.Generic;

namespace office_equipment_repair.Models;

public partial class TypesProblem
{
    public int Id { get; set; }

    public string ProblemType { get; set; } = null!;

    public virtual ICollection<Diagnostic> Diagnostics { get; set; } = new List<Diagnostic>();
}
