using System;
using System.Collections.Generic;

namespace Entities;

public partial class Receipt
{
    public int ReceiptId { get; set; }

    public int? InvoiceId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public decimal? AmountReceived { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public virtual Invoice? Invoice { get; set; }
}
