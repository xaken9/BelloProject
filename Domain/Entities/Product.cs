using System;
using System.Collections.Generic;
using Domain.Common;

namespace Domain.Entities;

public partial class Product : BaseAuditableEntity
{

    public int? BranchId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? StockQuantity { get; set; }

    public virtual Branch? Branch { get; set; }
}
