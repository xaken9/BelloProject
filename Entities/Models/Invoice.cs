using System;
using System.Collections.Generic;

namespace Entities;

public partial class Invoice
{
    public int InvoiceId { get; set; }

    public int? OrderId { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public virtual Order? Order { get; set; }

    public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();
}
