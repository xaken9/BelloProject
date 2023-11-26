using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Request
{
    public class ProductBranchDTORequest
    {
        public BranchDTORequest BranchDTORequest { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? StockQuantity { get; set; }
    }
}
