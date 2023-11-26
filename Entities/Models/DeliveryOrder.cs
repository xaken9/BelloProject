﻿using System;
using System.Collections.Generic;

namespace Entities;

public partial class DeliveryOrder
{
    public int DeliveryOrderId { get; set; }

    public int? OrderId { get; set; }

    public DateTime? ShipmentDate { get; set; }

    public string? ShipmentStatus { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public virtual Order? Order { get; set; }
}
