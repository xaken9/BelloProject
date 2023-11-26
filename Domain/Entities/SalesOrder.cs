using System;
using System.Collections.Generic;
using Domain.Common;

namespace Domain.Entities;

public partial class SalesOrder : BaseAuditableEntity
{
    public int? OrderId { get; set; }

    public DateTime? SalesOrderDate { get; set; }

    public string? Status { get; set; }

    public virtual Order? Order { get; set; }
}
