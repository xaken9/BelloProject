using System;
using System.Collections.Generic;

namespace Entities;

public partial class DebitNote
{
    public int DebitNoteId { get; set; }

    public int? OrderId { get; set; }

    public DateTime? DebitDate { get; set; }

    public string? Reason { get; set; }

    public decimal? DebitAmount { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public virtual Order? Order { get; set; }
}
