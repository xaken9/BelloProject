using System;
using System.Collections.Generic;

namespace Entities;

public partial class SalesOrder
{
    public int SalesOrderId { get; set; }

    public int? OrderId { get; set; }

    public DateTime? SalesOrderDate { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public virtual Order? Order { get; set; }
}
