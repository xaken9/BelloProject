using System;
using System.Collections.Generic;
using Domain.Common;

namespace Domain.Entities;

public partial class CreditNote : BaseAuditableEntity
{
    public int? OrderId { get; set; }

    public DateTime? CreditDate { get; set; }

    public string? Reason { get; set; }

    public decimal? CreditAmount { get; set; }
    public virtual Order? Order { get; set; }
}
