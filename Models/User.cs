﻿using System;
using System.Collections.Generic;

namespace office_equipment_repair.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? TypeId { get; set; }

    public virtual TypesUser? Type { get; set; }
}
