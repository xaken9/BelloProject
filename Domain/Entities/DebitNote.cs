using System;
using System.Collections.Generic;
using Domain.Common;

namespace Domain.Entities;

public partial class DebitNote: BaseAuditableEntity
{

    public int? OrderId { get; set; }

    public DateTime? DebitDate { get; set; }

    public string? Reason { get; set; }

    public decimal? DebitAmount { get; set; }

    public virtual Order? Order { get; set; }
}
