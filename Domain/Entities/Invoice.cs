using System;
using System.Collections.Generic;
using Domain.Common;

namespace Domain.Entities;

public partial class Invoice : BaseAuditableEntity
{
    public int? OrderId { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual Order? Order { get; set; }

    public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();
}
