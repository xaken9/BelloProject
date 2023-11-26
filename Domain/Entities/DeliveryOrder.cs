using System;
using System.Collections.Generic;
using Domain.Common;

namespace Domain.Entities;

public partial class DeliveryOrder : BaseAuditableEntity
{
    public int? OrderId { get; set; }

    public DateTime? ShipmentDate { get; set; }

    public string? ShipmentStatus { get; set; }
    public virtual Order? Order { get; set; }
}
