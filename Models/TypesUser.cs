using System;
using System.Collections.Generic;

namespace office_equipment_repair.Models;

public partial class TypesUser
{
    public int Id { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
