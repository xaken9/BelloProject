using System;
using System.Collections.Generic;
using Domain.Common;

namespace Domain.Entities;

public partial class Receipt : BaseAuditableEntity
{
    public int? InvoiceId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public decimal? AmountReceived { get; set; }

    public virtual Invoice? Invoice { get; set; }
}
