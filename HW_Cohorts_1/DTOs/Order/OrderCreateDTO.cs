using HW_Cohorts_1.Entities;
using HW_Cohorts_1.Enums;

namespace HW_Cohorts_1.DTOs.Order
{
    public class OrderCreateDTO
    {
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public string Description { get; set; }
    }
}
