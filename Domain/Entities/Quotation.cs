using System;
using System.Collections.Generic;
using Domain.Common;

namespace Domain.Entities;

public partial class Quotation : BaseAuditableEntity
{
    public int? CustomerId { get; set; }

    public DateTime? QuotationDate { get; set; }

    public string? Status { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
