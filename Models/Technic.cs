using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace office_equipment_repair.Models;

public partial class Technic
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Model { get; set; } = null!;

    public string SerialNumber { get; set; } = null!;

    public int OrganizationId { get; set; }

    public DateOnly ReceptionDate { get; set; }

    public virtual ICollection<Diagnostic> Diagnostics { get; set; } = new List<Diagnostic>();

    public virtual ICollection<HistoryRepair> HistoryRepairs { get; set; } = new List<HistoryRepair>();
}
