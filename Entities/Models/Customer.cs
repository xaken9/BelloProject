using System;
using System.Collections.Generic;

namespace Entities;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? ContactInfo { get; set; }

    public string? Address { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public virtual ICollection<Quotation> Quotations { get; set; } = new List<Quotation>();
}
