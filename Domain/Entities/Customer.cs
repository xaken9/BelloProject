using System;
using System.Collections.Generic;
using Domain.Common;

namespace Domain.Entities;

public partial class Customer: BaseAuditableEntity
{
    public string? CustomerName { get; set; }

    public string? ContactInfo { get; set; }

    public string? Address { get; set; }
    public virtual ICollection<Quotation> Quotations { get; set; } = new List<Quotation>();
}
