﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Packt.Shared;

[Keyless]
public partial class EmployeeTerritory
{
    [Required]
    [Column(TypeName = "INT")]
    public int EmployeeId { get; set; }

    [Column(TypeName = "nvarchar] (20")]
    public string TerritoryId { get; set; } = null!;
}
