using System;
using System.Collections.Generic;

namespace Entities;

public partial class CreditNote
{
    public int CreditNoteId { get; set; }

    public int? OrderId { get; set; }

    public DateTime? CreditDate { get; set; }

    public string? Reason { get; set; }

    public decimal? CreditAmount { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public virtual Order? Order { get; set; }
}
