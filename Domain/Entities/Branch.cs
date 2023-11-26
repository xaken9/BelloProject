using System;
using System.Collections.Generic;
using Domain.Common;

namespace Domain.Entities;

public partial class Branch : BaseAuditableEntity
{
    public string? BranchName { get; set; }
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
