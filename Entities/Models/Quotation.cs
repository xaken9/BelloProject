using System;
using System.Collections.Generic;

namespace Entities;

public partial class Quotation
{
    public int QuotationId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? QuotationDate { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
